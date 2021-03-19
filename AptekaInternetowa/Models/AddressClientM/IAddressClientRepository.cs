using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.AddressClientM
{
    public interface IAddressClientRepository
    {
        bool Add(AddressClient addressClient);
        bool Update(AddressClient addressClient);
        AddressClient GetById(int Id);
    }
}
