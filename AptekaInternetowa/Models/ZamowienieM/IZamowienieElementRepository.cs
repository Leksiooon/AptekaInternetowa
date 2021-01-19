using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ZamowienieM
{
    public interface IZamowienieElementRepository
    {
        void DodajZamowienieElement(ZamowienieElement zamowienieElement);
        void UsunZamowienieElement(ZamowienieElement zamowienieElement);
        ZamowienieElement PobierzZamowienieElementOId(int zamowienieElementId);
    }
}
