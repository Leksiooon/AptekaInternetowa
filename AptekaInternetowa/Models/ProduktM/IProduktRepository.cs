using System.Collections.Generic;

namespace AptekaInternetowa.Models.ProduktM
{
    public interface IProduktRepository
    {
        IEnumerable<Produkt> PobierzWszystkieProdukty();
        Produkt PobierzProduktOId(int produktId);
    }
}
