using AptekaInternetowa.Models.ViewModels;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;

namespace AptekaInternetowa.Controllers
{
    public class ZamowienieElementController : Controller
    {
        private readonly IZamowienieElementRepository _zamowienieElement;

        public ZamowienieElementController(IZamowienieElementRepository zamowienieElement)
        {
            _zamowienieElement = zamowienieElement;
        }

        [HttpPost]
        public IActionResult Add(SzczegolyVM szczegolyVM)
        {
            var ZamowienieElement = new ZamowienieElement
            {
                Ilosc = szczegolyVM.ilosc,
                ProduktId = szczegolyVM.Produkt.Id
            };

            _zamowienieElement.DodajZamowienieElement(ZamowienieElement);

            return RedirectToAction("Szczegoly", "Home", new { id = szczegolyVM.Produkt.Id });
        }
    }
}
