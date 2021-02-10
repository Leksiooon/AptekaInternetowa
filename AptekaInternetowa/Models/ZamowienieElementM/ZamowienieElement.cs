using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.ZamowienieM;

namespace AptekaInternetowa.Models.ZamowienieElementM
{
    public class ZamowienieElement
    {
        public int Id { get; set; }
        public int Ilosc { get; set; }

        //sekcja odwołania do relacji z Produkt
        public Produkt Produkt { get; set; }

        //sekcja odwołania do relacji z Zamowienie
        public Zamowienie Zamowienie { get; set; }
    }
}
