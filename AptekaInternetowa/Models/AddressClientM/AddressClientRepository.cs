using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.AddressClientM
{
    public class AddressClientRepository : IAddressClientRepository
    {
        private readonly AppDbContext _appDbContext;

        public AddressClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool Add(AddressClient addressClient)
        {
            _appDbContext.AddressClient.Add(addressClient);
            _appDbContext.SaveChanges();

            return true;
        }

        public AddressClient GetById(int Id)
        {
            var addressClient = _appDbContext.AddressClient.Find(Id);
            if (addressClient == null)
                return null;
            return addressClient;
        }

        public bool Update(AddressClient addressClient)
        {
            _appDbContext.Update(addressClient);
            _appDbContext.SaveChanges();

            return true;
        }
    }
}
