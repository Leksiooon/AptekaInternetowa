using AptekaInternetowa.Models.ProduktM;
using System.Collections.Generic;

namespace AptekaInternetowa.Models.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Produkt> Produkty { get; set; }
    }
}
