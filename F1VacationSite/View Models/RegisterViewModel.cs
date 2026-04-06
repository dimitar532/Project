using System.ComponentModel.DataAnnotations;
using F1VacationSite.Constants;

namespace F1VacationSite.View_Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(UserConstants.FirstNameMaxLength, MinimumLength = UserConstants.FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(UserConstants.LastNameMaxLength, MinimumLength = UserConstants.LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = UserConstants.PasswordMinLength)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}