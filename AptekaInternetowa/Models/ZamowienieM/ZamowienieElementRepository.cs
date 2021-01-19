using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public class ZamowienieElementRepository : IZamowienieElementRepository
    {
        private readonly AppDbContext _appDbContext;

        public ZamowienieElementRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DodajZamowienieElement(ZamowienieElement zamowienieElement)
        {
            _appDbContext.ZamowienieElement.Add(zamowienieElement);
            _appDbContext.SaveChanges();
        }

        public ZamowienieElement PobierzZamowienieElementOId(int zamowienieElementId)
        {
            return _appDbContext.ZamowienieElement.FirstOrDefault(x => x.Id == zamowienieElementId);
        }

        public void UsunZamowienieElement(ZamowienieElement zamowienieElement)
        {
            _appDbContext.ZamowienieElement.Remove(zamowienieElement);
            _appDbContext.SaveChanges();
        }
    }
}
