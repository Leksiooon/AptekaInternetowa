using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieElementM;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;

namespace AptekaInternetowa.Controllers
{
    public class ProduktController : Controller
    {
        private readonly IProduktRepository _produktRepository;

        public ProduktController(IZamowienieElementRepository zamowienieElementRepository, IProduktRepository produktRepository, IAppUserRepository appUserRepository, IZamowienieRepository zamowienieRepository)
        {
            _produktRepository = produktRepository;
        }

        public IActionResult Szczegoly(int id, string alert = null)
        {
            var produkt = _produktRepository.GetById(id);

            if (produkt == null)
                return NotFound();

            var SzczegolyVM = new SzczegolyVM
            {
                Produkt = produkt,
                Ilosc = 1,
                Alert = alert,
            };

            ViewBag.Title = produkt.Nazwa.ToString();

            return View(SzczegolyVM);
        }
    }
}
