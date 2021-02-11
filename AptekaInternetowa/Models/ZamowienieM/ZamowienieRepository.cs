using Microsoft.EntityFrameworkCore;
using System;
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
            var zamowienie = _appDbContext.Zamowienie
                .Where(x => x.Id == Id)
                .Include(x => x.ElementyZamowienia).ThenInclude(x => x.Produkt)
                .FirstOrDefault();

            zamowienie.PoliczWartosc();

            return zamowienie;
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
