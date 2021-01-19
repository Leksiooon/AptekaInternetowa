using AptekaInternetowa.Models.ProduktM;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public class ZamowienieElement
    {
        public int Id { get; set; }
        public int Ilosc { get; set; }

        //sekcja odsowała do relacji z Produkt
        public Produkt Produkt { get; set; }
        public int ProduktId { get; set; }
        

    }
}
