using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AptekaInternetowa.ViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly IZamowienieRepository _zamowienieRepository;
        private readonly IAppUserRepository _appUser;

        public NavBarViewComponent(IZamowienieRepository zamowienieRepository, IAppUserRepository appUser)
        {
            _zamowienieRepository = zamowienieRepository;
            _appUser = appUser;
        }

        public IViewComponentResult Invoke()
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            var basket = _appUser.GetOtwarteZamowienieUseraOId(Convert.ToInt32(userId));
            
            return View(basket);
        }
    }
}
