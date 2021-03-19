using AptekaInternetowa.Models.UserM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.AddressClientM
{
    public class AddressClient
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; } // województwo
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string StreetNumber { get; set; } // numer budynku/lokalu

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
