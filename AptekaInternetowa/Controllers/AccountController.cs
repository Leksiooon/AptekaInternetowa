using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

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
            var globalVM = new GlobalVM()
            {
                Title = "Logowanie",
            };

            return View(globalVM);
        }

        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _appUserRepository.GetAppUserByName(loginVM.UserName);

                if (user != null  && user.Password == loginVM.Password)
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
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wpisane dane są niepoprawne!");
            }

            var globalVM = new GlobalVM()
            {
                Title = "Logowanie",
                LoginVM = loginVM,
            };

            return View(globalVM);
        }


        [HttpGet]
        public IActionResult Register()
        {
            var globalVM = new GlobalVM()
            {
                Title = "Rejestracja",
                RegisterVM = new RegisterVM(),
            };

            return View(globalVM);
        }

        [HttpPost]
        public IActionResult Register(RegisterVM registerVM)
        {

            // todo dodać walidacjęformularza dla nazwy uzytkownika i hasło
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    Username = registerVM.UserName,
                    Password = registerVM.Password
                };

                var result = _appUserRepository.Add(user);

                if (result)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Użytkownik o podanej nazwie username już istnieje!");
            }

            return View(registerVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
