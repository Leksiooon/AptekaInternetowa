using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IZamowienieRepository _zamowienieElementRepository;

        public ZamowienieController(IZamowienieRepository zamowienieRepository, IAppUserRepository appUserRepository, IZamowienieRepository zamowienieElementRepository)
        {
            _zamowienieRepository = zamowienieRepository;
            _appUserRepository = appUserRepository;
            _zamowienieElementRepository = zamowienieElementRepository;
        }

        [Authorize]
        public IActionResult ShowBasket(int id)
        {
            var zamowienie = _zamowienieRepository.GetById(id);

            if (zamowienie == null)
                return NotFound();

            ViewBag.Title = "Twój koszyk";
            var basketVM = new BasketVM() { Zamowienie = zamowienie };

            return View(basketVM);
        }

        [Authorize]
        public IActionResult Order(int id)
        {
            var zamowienie = _zamowienieRepository.GetById(id);

            if (zamowienie.ElementyZamowienia == null || zamowienie.ElementyZamowienia.Count == 0)
                return RedirectToAction("ShowBasket", "Zamowienie", new { id = id });

            if (zamowienie != null)
            {
                zamowienie.Status = ZamowienieType.Zrealizowane;
                zamowienie.SubmissionDate = DateTime.Now;
                _zamowienieRepository.Update(zamowienie);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult SubmissionedOrders()
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
                return NotFound();

            var appUser = _appUserRepository.GetAppUserById(Convert.ToInt32(userId));
            var zamowienia = appUser.Zamowienia;

            var koszyk = zamowienia.Where(x => x.Status == ZamowienieType.Otwarte).ToList()[0];
            zamowienia.Remove(koszyk);

            ViewBag.Title = "Historia zamowień";
            var SubmissionedOrdersVM = new SubmissionedOrders() { Zamowienia = zamowienia };


            return View(SubmissionedOrdersVM);
        }
    }
}
