using AptekaInternetowa.Models.AddressClientM;
using AptekaInternetowa.Models.UserM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace AptekaInternetowa.Controllers
{
    public class AddressClientController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly IAddressClientRepository _addressClientRepository;

        public AddressClientController(AppUserRepository appUserRepository, IAddressClientRepository addressClientRepository)
        {
            _appUserRepository = appUserRepository;
            _addressClientRepository = addressClientRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Save()
        {
            AddressClient addressClient = new AddressClient();

            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var user = _appUserRepository.GetAppUserById(Convert.ToInt32(userId));



            return View();
        }
    }
}
