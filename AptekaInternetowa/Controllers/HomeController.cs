using AptekaInternetowa.Models.ProduktM;
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

        public IActionResult Szczegoly(int id)
        {
            var produkt = _produktRepository.GetById(id);

            if (produkt == null)
                return NotFound();

            var SzczegolyVM = new SzczegolyVM
            {
                Produkt = produkt,
                ilosc = 1
            };

            return View(SzczegolyVM);
        }
    }
}
