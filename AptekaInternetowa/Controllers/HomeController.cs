using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IZamowienieRepository _zamowienieRepository;
        private readonly IProduktRepository _produktRepository;
        private readonly IAppUserRepository _appUserRepository;

        public HomeController(IProduktRepository produktRepository, IAppUserRepository appUserRepository, IZamowienieRepository zamowienieRepository)
        {
            _produktRepository = produktRepository;
            _appUserRepository = appUserRepository;
            _zamowienieRepository = zamowienieRepository;
        }

        public IActionResult Index()
        {
            var navBarVM = new NavBarVM();
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId != null)
            {
                var zamowienie = _appUserRepository.GetOtwarteZamowienieUseraOId(Convert.ToInt32(userId));
                navBarVM.Zamowienie = zamowienie;
            }

            var produkty = _produktRepository.GetAll();

            var homeVM = new HomeVM()
            {
                Produkty = produkty.ToList(),
            };

            GlobalVM globalVM = new GlobalVM()
            {
                Title = "Przegląd produktow",
                HomeVM = homeVM,
                NavBarVM = navBarVM,
            };

            return View(globalVM);
        }
    }
}
