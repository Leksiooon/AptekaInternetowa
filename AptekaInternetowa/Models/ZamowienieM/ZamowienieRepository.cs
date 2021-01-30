﻿using System;
using System.Linq;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public class ZamowienieRepository : IZamowienieRepository
    {
        private readonly AppDbContext _appDbContext;

        public ZamowienieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Zamowienie zamowienie)
        {
            _appDbContext.Zamowienie.Add(zamowienie);
            _appDbContext.SaveChanges();
        }

        public Zamowienie GetById(int Id)
        {
            return _appDbContext.Zamowienie.FirstOrDefault(x => x.Id == Id);
        }

        public void Remove(Zamowienie zamowienie)
        {
            _appDbContext.Zamowienie.Remove(zamowienie);
            _appDbContext.SaveChanges();
        }

        public void Update(Zamowienie zamowienie)
        {
            _appDbContext.Zamowienie.Update(zamowienie);
            _appDbContext.SaveChanges();
        }
    }
}
