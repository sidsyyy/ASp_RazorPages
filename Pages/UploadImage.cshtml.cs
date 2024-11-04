using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace WebApplication2.Pages
{
    public class UploadImageModel : PageModel
    {
        [BindProperty]
        public required IFormFile UploadedFile { get; set; }

        public string RandomImageUrl { get; private set; }
        public string UploadedImageUrl { get; private set; }

        public void OnGet()
        {
            RandomImageUrl = "https://picsum.photos/200/300"; // Random image
        }

        public IActionResult OnPost()
        {
            if (UploadedFile != null && UploadedFile.Length > 0)
            {
                var filePath = Path.Combine("wwwroot/uploads", UploadedFile.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    UploadedFile.CopyTo(stream);
                }

                UploadedImageUrl = "/uploads/" + UploadedFile.FileName; // Relative URL to access the image
                return RedirectToPage();
            }

            ModelState.AddModelError("UploadedFile", "Please upload a file.");
            return Page();
        }
    }
}
