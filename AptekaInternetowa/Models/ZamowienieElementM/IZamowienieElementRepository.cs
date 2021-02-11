using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ZamowienieElementM
{
    public interface IZamowienieElementRepository
    {
        void Add(ZamowienieElement zamowienieElement);
        void Update(ZamowienieElement zamowienieElement);
        void Remove(ZamowienieElement zamowienieElement);
        ZamowienieElement GetById(int zamowienieElementId);
    }
}
