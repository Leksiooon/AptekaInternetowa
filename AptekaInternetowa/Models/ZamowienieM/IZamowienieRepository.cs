using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public interface IZamowienieRepository
    {
        void Add(Zamowienie zamowienie);
        void Remove(Zamowienie zamowienie);
        void Update(Zamowienie zamowienie);
        Zamowienie GetById(int Id);
    }
}
