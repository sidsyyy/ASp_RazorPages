using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Pages.ViewModel;

namespace WebApplication2.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public RegistrationFormModel newUser { set; get; }

        [BindProperty]
        [Required(ErrorMessage ="Select an optioin")]
        public string CourseList { get; set; }

        public List<SelectListItem> CourseOptions { get; set; }

        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CourseOptions = new List<SelectListItem>{
            new() { Value = "1", Text = "Option 1" },
            new() { Value = "2", Text = "Option 2" }
            };

        }
      
        public IActionResult OnPost() 
        
        {
            CourseOptions = new List<SelectListItem>{
            new() { Value = "1", Text = "Option 1" },
            new() { Value = "2", Text = "Option 2" }
            };

            Console.WriteLine("Cliced on post");
           
            if (!ModelState.IsValid) { 
                return Page();
            }

            TempData["message"] = "Registration Succesfull...";
            TempData["link"] = "Index";

            return RedirectToPage("CommonResponsePage");
        }
    }

}
