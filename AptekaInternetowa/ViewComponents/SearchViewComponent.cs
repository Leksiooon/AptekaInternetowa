using AptekaInternetowa.Models.ProduktM;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AptekaInternetowa.ViewComponents
{
    public class SearchViewComponent : ViewComponent
    {
        private readonly IProduktRepository _produktRepository;

        public SearchViewComponent(IProduktRepository produktRepository)
        {
            _produktRepository = produktRepository;
        }

        public IViewComponentResult Invoke()
        {
            var products = _produktRepository.GetAll().ToList();

            return View(products);
        }
    }
}
