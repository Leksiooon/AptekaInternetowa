﻿using AptekaInternetowa.Models.ProduktM;
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

            return View(SzczegolyVM);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(SzczegolyVM szczegolyVM)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                var user = _appUserRepository.GetAppUserById(Convert.ToInt16(userId));
                var zamowienie = (user.Zamowienia.Find(x => x.Status == ZamowienieType.Otwarte));

                if (zamowienie == null)
                {
                    zamowienie = new Zamowienie
                    {
                        AppUser = user,
                        Status = ZamowienieType.Otwarte,
                        Wartosc = 0,
                    };

                    _zamowienieRepository.Add(zamowienie);
                }

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
