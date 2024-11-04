using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages.ViewModel
{
    public class FormModelClass
    {
        [Required(ErrorMessage ="Email is required")]

        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
    public class RegistrationFormModel {
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(40,MinimumLength =8)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Name { get; set; }

        [RegularExpression("([0-9]+)",ErrorMessage ="Numbers must Contain 0-9 letters only")]
        public string Number { get; set; }

        [Range(18,150)]
        public int Age { get; set; }
    }
    
}
