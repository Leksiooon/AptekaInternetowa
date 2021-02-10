﻿using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            return _appDbContext.AppUser
                .Where(x => x.Id == Id)
                .Include(x => x.Zamowienia)
                .SingleOrDefault();
        }

        public AppUser GetAppUserByName(string UserName)
        {
            return _appDbContext.AppUser.FirstOrDefault(x => x.Username == UserName);
        }

        public Zamowienie GetOtwarteZamowienieUseraOId(int Id)
        {
              return _appDbContext.Zamowienie
                .Where(x => x.AppUser.Id == Id)
                .Where(x => x.Status == ZamowienieType.Otwarte)
                .Include(x => x.ElementyZamowienia).ThenInclude(x => x.Produkt)
                .SingleOrDefault();
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