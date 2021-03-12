using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieElementM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class ZamowienieElementController : Controller
    {
        private readonly IProduktRepository _produktRepository;
        private readonly IZamowienieElementRepository _zamowienieElementRepository;
        private readonly IAppUserRepository _appUserRepository;

        public ZamowienieElementController(IZamowienieElementRepository zamowienieElementRepository, IProduktRepository produktRepository, IAppUserRepository appUserRepository)
        {
            _zamowienieElementRepository = zamowienieElementRepository;
            _produktRepository = produktRepository;
            _appUserRepository = appUserRepository;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(SzczegolyVM szczegolyVM)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
                var produkt = _produktRepository.GetById(szczegolyVM.Produkt.Id);

                var zamowienie = _appUserRepository.GetOtwarteZamowienieUseraOId(Convert.ToInt32(userId));
                var zamowienieElement = zamowienie.ZnajdzZamowienieElement(produkt);
                if (zamowienieElement != null)
                {
                    zamowienieElement.Ilosc += szczegolyVM.Ilosc;
                    _zamowienieElementRepository.Update(zamowienieElement);
                }
                else
                {
                    var ZamowienieElement = new ZamowienieElement
                    {
                        Ilosc = szczegolyVM.Ilosc,
                        Produkt = produkt,
                        Zamowienie = zamowienie,
                    };

                    _zamowienieElementRepository.Add(ZamowienieElement);
                }
            }

            return RedirectToAction("Szczegoly", "Produkt", new { id = szczegolyVM.Produkt.Id, alert = "Produkt został dodany do koszyka :)" });
        }

        [Authorize]
        public IActionResult Remove(int zamowienieElementId)
        {
            var zamowienieElement = _zamowienieElementRepository.GetById(zamowienieElementId);

            if (zamowienieElement != null)
                _zamowienieElementRepository.Remove(zamowienieElement);

            return RedirectToAction("ShowBasket", "Zamowienie", new { id = zamowienieElement.Zamowienie.Id });
        }

        [Authorize]
        public IActionResult Minus(int zamowienieElementId)
        {
            var zamowienieElement = _zamowienieElementRepository.GetById(zamowienieElementId);

            if (zamowienieElement.Ilosc == 1)
                return RedirectToAction("Remove", new { zamowienieElementId = zamowienieElementId });

            if (zamowienieElement != null)
            {
                zamowienieElement.Ilosc -= 1;
                _zamowienieElementRepository.Update(zamowienieElement);
            }

            return RedirectToAction("ShowBasket", "Zamowienie", new { id = zamowienieElement.Zamowienie.Id });
        }

        [Authorize]
        public IActionResult Plus(int zamowienieElementId)
        {
            var zamowienieElement = _zamowienieElementRepository.GetById(zamowienieElementId);

            if (zamowienieElement != null && zamowienieElement.Ilosc <= 10)
            {
                zamowienieElement.Ilosc += 1;
                _zamowienieElementRepository.Update(zamowienieElement);
            }

            return RedirectToAction("ShowBasket", "Zamowienie", new { id = zamowienieElement.Zamowienie.Id });
        }
    }
}
