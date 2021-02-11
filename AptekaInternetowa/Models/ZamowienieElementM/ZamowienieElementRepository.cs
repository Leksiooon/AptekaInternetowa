using System.Linq;

namespace AptekaInternetowa.Models.ZamowienieElementM
{
    public class ZamowienieElementRepository : IZamowienieElementRepository
    {
        private readonly AppDbContext _appDbContext;

        public ZamowienieElementRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(ZamowienieElement zamowienieElement)
        {
            _appDbContext.ZamowienieElement.Add(zamowienieElement);
            _appDbContext.SaveChanges();
        }

        public ZamowienieElement GetById(int zamowienieElementId)
        {
            return _appDbContext.ZamowienieElement.FirstOrDefault(x => x.Id == zamowienieElementId);
        }

        public void Remove(ZamowienieElement zamowienieElement)
        {
            _appDbContext.ZamowienieElement.Remove(zamowienieElement);
            _appDbContext.SaveChanges();
        }

        public void Update(ZamowienieElement zamowienieElement)
        {
            _appDbContext.Update(zamowienieElement);
            _appDbContext.SaveChanges();
        }
    }
}
