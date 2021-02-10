using System.Collections.Generic;

namespace AptekaInternetowa.Models.ProduktM
{
    public interface IProduktRepository
    {
        IEnumerable<Produkt> GetAll();
        Produkt GetById(int produktId);
    }
}
