﻿using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace AptekaInternetowa.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;

        public AccountController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.Title = "Logowanie";
            var LoginVM = new LoginVM();

            return View(LoginVM);
        }

        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _appUserRepository.GetAppUserByName(loginVM.UserName);

                if (user != null && BC.Verify(loginVM.Password, user.Password))
                {
                    Logging(user);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wpisane dane są niepoprawne!");
            }

            ViewBag.Title = "Logowanie";

            return View(loginVM);
        }

        private void Logging(AppUser user)
        {
            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                    };
            var identity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var props = new AuthenticationProperties();
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Title = "Rejestracja";
            var RegisterVM = new RegisterVM();

            return View(RegisterVM);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterVM registerVM)
        {
            var checkUser = _appUserRepository.GetAppUserByName(registerVM.UserName);

            if (checkUser != null)
                ModelState.AddModelError("", "Użytkownik o podanej nazwie username już istnieje!");

            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    Username = registerVM.UserName,
                    Password = BC.HashPassword(registerVM.Password),
                };

                var result = _appUserRepository.Add(user);

                if (result)
                {
                    Logging(user);
                    return RedirectToAction("Index", "Home");
                }
            }

            ViewBag.Title = "Rejestracja";
            var RegisterVM = registerVM;

            return View(RegisterVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
