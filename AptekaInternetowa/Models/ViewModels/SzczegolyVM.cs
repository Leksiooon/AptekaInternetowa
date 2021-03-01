using AptekaInternetowa.Models.ProduktM;

namespace AptekaInternetowa.Models.ViewModels
{
    public class SzczegolyVM
    {
        public Produkt Produkt { get; set; }
        public int Ilosc { get; set; }
        public string Alert { get; set; }
    }
}
