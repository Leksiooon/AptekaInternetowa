namespace AptekaInternetowa.Models.ProduktM
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public double Cena { get; set; }
        public string ZdjecieUrl { get; set; }
        public int LiczbaDostępnychSztuk { get; set; }
        public string Sklad { get; set; }
        public string Dzialanie { get; set; }
        public string Przeciwwskazania { get; set; }
        public string Wskazania { get; set; }
        public string Dawkowanie { get; set; }
        public string DodatkoweInformacje { get; set; }
    }
}
