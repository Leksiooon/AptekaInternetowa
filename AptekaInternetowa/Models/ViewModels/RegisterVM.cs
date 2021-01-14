using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AptekaInternetowa.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Powtórz hasło")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Podane hasła muszą być identyczne!")]
        public string ComparePassword { get; set; }
    }
}
