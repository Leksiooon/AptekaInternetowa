using AptekaInternetowa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
