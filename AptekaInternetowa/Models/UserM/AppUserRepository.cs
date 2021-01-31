using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.UserM
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public AppUserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool Add(AppUser appUser)
        {
            // sprawdzenie czy podany Username jest unique
            var result = _appDbContext.AppUser.FirstOrDefault(x => x.Username == appUser.Username);

            if (result != null)
                return false;

            _appDbContext.AppUser.Add(appUser);
            _appDbContext.SaveChanges();
            return true;
        }

        public AppUser GetAppUserById(int Id)
        {
            return _appDbContext.AppUser.FirstOrDefault(x => x.Id == Id);
        }

        public AppUser GetAppUserByName(string UserName)
        {
            return _appDbContext.AppUser.FirstOrDefault(x => x.Username == UserName);
        }

        public void Remove(AppUser appUser)
        {
            _appDbContext.AppUser.Remove(appUser);
            _appDbContext.SaveChanges();
        }

        public void Update(AppUser appUser)
        {
            _appDbContext.AppUser.Update(appUser);
            _appDbContext.SaveChanges();
        }
    }
}
