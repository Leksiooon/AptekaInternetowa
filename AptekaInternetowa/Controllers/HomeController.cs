using AptekaInternetowa.Models.ProduktM;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
