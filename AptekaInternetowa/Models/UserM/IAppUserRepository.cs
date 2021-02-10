using AptekaInternetowa.Models.ZamowienieM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.UserM
{
    public interface IAppUserRepository
    {
        bool Add(AppUser appUser);
        void Remove(AppUser appUser);
        void Update(AppUser appUser);
        AppUser GetAppUserById(int Id);
        AppUser GetAppUserByName(string UserName);
        Zamowienie GetOtwarteZamowienieUseraOId(int Id);
    }
}
