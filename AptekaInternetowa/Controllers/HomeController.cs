﻿using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AptekaInternetowa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduktRepository _produktRepository;

        public HomeController(IProduktRepository produktRepository)
        {
            _produktRepository = produktRepository;
        }

        public IActionResult Index()
        {
            var produkty = _produktRepository.GetAll();

            var homeVM = new HomeVM()
            {
                Title = "Przegląd produktów",
                Produkty = produkty.ToList()
            };

            return View(homeVM);
        }
    }
}
