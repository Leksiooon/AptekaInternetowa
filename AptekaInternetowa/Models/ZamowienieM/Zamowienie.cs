using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ZamowienieElementM;
using System.Collections.Generic;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public class Zamowienie
    {
        public int Id { get; set; }
        public double Wartosc { get; set; }
        public ZamowienieType Status { get; set; }

        //sekcja odwołania do relacji z AppUser
        public AppUser AppUser { get; set; }

        //sekcja odwołania do kolekcji z Zamowienie
        public List<ZamowienieElement> ElementyZamowienia { get; set; }

        //public double PoliczWartosc() { }
    }
}
