using AptekaInternetowa.Models.UserM;
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

                if (user != null && BC.Verify(loginVM.Password, user.Password))
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
        [AllowAnonymous]
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
                    return RedirectToAction("Index", "Home");
            }

            var globalVM = new GlobalVM()
            {
                Title = "Rejestracja",
                RegisterVM = new RegisterVM(),
            };

            return View(globalVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
