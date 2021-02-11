using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Controllers
{
    public class ZamowienieController : Controller
    {
        private readonly IZamowienieRepository _zamowienieRepository;

        public ZamowienieController(IZamowienieRepository zamowienieRepository)
        {
            _zamowienieRepository = zamowienieRepository;
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
    }
}
