using AptekaInternetowa.Models.ZamowienieM;
using System.Collections.Generic;

namespace AptekaInternetowa.Models.UserM
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //sekcja odwołania do kolekcji Zamowień
        public List<Zamowienie> Zamowienia { get; set; }
    }
}
