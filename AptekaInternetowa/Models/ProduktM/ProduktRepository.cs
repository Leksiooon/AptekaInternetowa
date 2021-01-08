using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ProduktM
{
    public class ProduktRepository : IProduktRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProduktRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Produkt PobierzProduktOId(int produktId)
        {
            return _appDbContext.Produkty.FirstOrDefault(s => s.Id == produktId);
        }

        public IEnumerable<Produkt> PobierzWszystkieProdukty()
        {
            return _appDbContext.Produkty;
        }
    }
}
