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
        public IActionResult Add(int id, int ilosc)
        {
            var ZamowienieElement = new ZamowienieElement
            {
                Ilosc = ilosc,
                ProduktId = id
            };

            _zamowienieElement.DodajZamowienieElement(ZamowienieElement);

            return RedirectToAction("Home", "Szczegoly",id);
        }
    }
}
