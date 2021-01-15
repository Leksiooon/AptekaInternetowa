using AptekaInternetowa.Models.ProduktM;
using System.Collections.Generic;

namespace AptekaInternetowa.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Produkt> Produkty { get; set; }
    }
}
