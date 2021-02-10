using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieElementM;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class ProduktController : Controller
    {
        private readonly IProduktRepository _produktRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IZamowienieElementRepository _zamowienieElementRepository;
        private readonly IZamowienieRepository _zamowienieRepository;

        public ProduktController(IZamowienieElementRepository zamowienieElementRepository, IProduktRepository produktRepository, IAppUserRepository appUserRepository, IZamowienieRepository zamowienieRepository)
        {
            _produktRepository = produktRepository;
            _appUserRepository = appUserRepository;
            _zamowienieElementRepository = zamowienieElementRepository;
            _zamowienieRepository = zamowienieRepository;
        }

        public IActionResult Szczegoly(int id)
        {
            var produkt = _produktRepository.GetById(id);

            if (produkt == null)
                return NotFound();

            var SzczegolyVM = new SzczegolyVM
            {
                Produkt = produkt,
                Ilosc = 1
            };

            var navBarVM = new NavBarVM();
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                var zamowienie = _appUserRepository.GetOtwarteZamowienieUseraOId(Convert.ToInt32(userId));
                zamowienie.PoliczWartosc();
                navBarVM.Zamowienie = zamowienie;
            }

            var globalVM = new GlobalVM()
            {
                Title = produkt.Nazwa.ToString(),
                SzczegolyVM = SzczegolyVM,
                NavBarVM = navBarVM,
            };

            return View(globalVM);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(SzczegolyVM szczegolyVM)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                var zamowienie = _appUserRepository.GetOtwarteZamowienieUseraOId(Convert.ToInt32(userId));

                var produkt = _produktRepository.GetById(szczegolyVM.Produkt.Id);
                var ZamowienieElement = new ZamowienieElement
                {
                    Ilosc = szczegolyVM.Ilosc,
                    Produkt = produkt,
                    Zamowienie = zamowienie,
                };

                _zamowienieElementRepository.Add(ZamowienieElement);
            }

            return RedirectToAction("Szczegoly", "Produkt", new { id = szczegolyVM.Produkt.Id });
        }
    }
}
