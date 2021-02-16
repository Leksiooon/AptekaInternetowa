using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class ZamowienieController : Controller
    {
        private readonly IZamowienieRepository _zamowienieRepository;
        private readonly IAppUserRepository _appUserRepository;

        public ZamowienieController(IZamowienieRepository zamowienieRepository, IAppUserRepository appUserRepository)
        {
            _zamowienieRepository = zamowienieRepository;
            _appUserRepository = appUserRepository;
        }

        public IActionResult ShowBasket(int id)
        {
            var zamowienie = _zamowienieRepository.GetById(id);

            if (zamowienie == null)
                return NotFound();

            var globalVM = new GlobalVM()
            {
                Title = "Twój koszyk",
                NavBarVM = new NavBarVM() { Zamowienie = zamowienie },
            };


            return View(globalVM);
        }

        public IActionResult Order(int id)
        {
            var zamowienie = _zamowienieRepository.GetById(id);

            if (zamowienie.ElementyZamowienia == null || zamowienie.ElementyZamowienia.Count == 0)
                return RedirectToAction("ShowBasket", "Zamowienie", new { id = id } );

            if (zamowienie != null)
            {
                zamowienie.Status = ZamowienieType.Zrealizowane;
                zamowienie.SubmissionDate = DateTime.Now;
                _zamowienieRepository.Update(zamowienie);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult SubmissionedOrders()
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
                return NotFound();

            var appUser = _appUserRepository.GetAppUserById(Convert.ToInt32(userId));
            var zamowienia = appUser.Zamowienia;

            var koszyk = zamowienia.Where(x => x.Status == ZamowienieType.Otwarte).ToList()[0];
            zamowienia.Remove(koszyk);

            var globalVM = new GlobalVM
            {
                Title = "Historia zamowień",
                NavBarVM = new NavBarVM() { Zamowienie = koszyk },
                SubmissionedOrdersVM = new SubmissionedOrders() { Zamowienia = zamowienia },
            };

            return View(globalVM);
        }

    }
}
