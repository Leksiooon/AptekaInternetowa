using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ViewModels
{
    public class GlobalVM
    {
        public string Title { get; set; }
        public SzczegolyVM SzczegolyVM { get; set; } // szczegółowe infromacje o jednym produkcie
        public HomeVM HomeVM { get; set; } // przeglad wszystkich dostępnych produktów
        public NavBarVM NavBarVM { get; set; }  // aktualny koszyk
        public LoginVM LoginVM { get; set; }
        public RegisterVM RegisterVM { get; set; }
        public SubmissionedOrders SubmissionedOrdersVM { get; set; }
    }
}
