using System.Collections.Generic;

namespace AptekaInternetowa.Models
{
    public interface IProduktRepository
    {
        IEnumerable<Produkt> PobierzWszystkieProdukty();
        Produkt pobierzProduktOId(int produktId);
    }
}
