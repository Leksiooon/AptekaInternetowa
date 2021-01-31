using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieElementM;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class ProduktController : Controller
    {

        private readonly IZamowienieElementRepository _zamowienieElement;
        private readonly IProduktRepository _produktRepository;

        public ProduktController(IZamowienieElementRepository zamowienieElement, IProduktRepository produktRepository)
        {
            _zamowienieElement = zamowienieElement;
            _produktRepository = produktRepository;
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

        [HttpPost]
        public IActionResult Add(SzczegolyVM szczegolyVM)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                var ZamowienieElement = new ZamowienieElement
                {
                    Ilosc = szczegolyVM.Ilosc,
                    Produkt = szczegolyVM.Produkt,
                };

                _zamowienieElement.Add(ZamowienieElement);
            }

            return RedirectToAction("Szczegoly", "Produkt", new { id = szczegolyVM.Produkt.Id });





        }


    }
}
