using AptekaInternetowa.Models.UserM;

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

        public virtual int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
