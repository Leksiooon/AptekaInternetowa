using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.ZamowienieM;

namespace AptekaInternetowa.Models.ZamowienieElementM
{
    public class ZamowienieElement
    {
        public int Id { get; set; }
        public int Ilosc { get; set; }

        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
