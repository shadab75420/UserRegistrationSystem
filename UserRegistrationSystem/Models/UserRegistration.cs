using System.ComponentModel.DataAnnotations;

namespace UserRegistrationSystem.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12, MinimumLength = 6,
            ErrorMessage = "Password must be between 6 and 12 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password",
            ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }
    }
}