using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AptekaInternetowa.Models.ViewModels
{
    public class RegisterVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        [MinLength(6, ErrorMessage = "Nazwa użytkownika musi mieć minimum 6 znaków")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        // Validacja poniżej
        //[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej: \n jedną dużą literę \n jedną małą literę \n jedną cyfrę \n mieć przynajmniej 8 znaków")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Powtórz hasło")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Podane hasła muszą być identyczne!")]
        public string ComparePassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();

            //walidacja hasła
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if (!hasNumber.IsMatch(Password))
                validationResults.Add(new ValidationResult("Hasło musi zawierać co najmniej jedną cyfrę"));

            if (!hasUpperChar.IsMatch(Password))
                validationResults.Add(new ValidationResult("Hasło musi zawierać co najmniej jedną dużą literę"));

            if (!hasLowerChar.IsMatch(Password))
                validationResults.Add(new ValidationResult("Hasło musi zawierać co najmniej jedną małą literę"));

            if (!hasMinimum8Chars.IsMatch(Password))
                validationResults.Add(new ValidationResult("Hasło musi zawierać co najmniej osiem znaków"));

            IEnumerable<ValidationResult> validationResults1 = validationResults;

            return validationResults1;
        }
    }

    
}
