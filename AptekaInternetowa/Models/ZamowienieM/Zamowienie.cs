using AptekaInternetowa.Models.ProduktM;
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

        public double PoliczWartosc()
        {
            double wartosc = 0;
            if (this.ElementyZamowienia == null)
                return 0;

            foreach (var item in this.ElementyZamowienia)
                wartosc += item.Produkt.Cena * item.Ilosc;

            this.Wartosc = wartosc;
            return wartosc;
        }

        public ZamowienieElement ZnajdzZamowienieElement(Produkt produkt)
        {
            if (this.ElementyZamowienia == null)
                return null;

            foreach (var item in this.ElementyZamowienia)
            {
                if (item.Produkt == produkt)
                    return item;
            }

            return null;
        }
    }
}
