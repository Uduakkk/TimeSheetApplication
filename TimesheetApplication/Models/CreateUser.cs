using System.ComponentModel.DataAnnotations;

namespace TimesheetApplication.Models
{
    public class CreateUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invaliid email address")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "at least 8 characters, at least one uppercase, at least one lowercase, at least one digit, at least one special character")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; } = string.Empty;
    }
}
