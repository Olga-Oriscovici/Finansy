using System.ComponentModel.DataAnnotations;

namespace Finansy.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Password do not match")]
        [Display(Name = " Confirm Password")]
        public string? PasswordConfirmation { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Address {  get; set; }
    }
}
