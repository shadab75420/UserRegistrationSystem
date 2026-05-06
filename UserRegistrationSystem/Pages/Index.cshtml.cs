using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserRegistrationSystem.Models;

namespace UserRegistrationSystem.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public UserRegistration RegisterUser { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                SuccessMessage = "Registration Successful!";
            }
        }
    }
}