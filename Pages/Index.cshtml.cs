using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Pages.ViewModel;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FormModelClass newUser { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["message"] = "Login Succesfull...";
            TempData["link"] = "HomePage";

            return RedirectToPage("CommonResponsePage");
        }
    }
}
