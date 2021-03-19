using AptekaInternetowa.Models.AddressClientM;
using AptekaInternetowa.Models.ZamowienieM;
using System.Collections.Generic;

namespace AptekaInternetowa.Models.UserM
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } // unique - set in onCreateDB
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Zamowienie> Zamowienia { get; set; }

        public AddressClient Address { get; set; }
    }
}
