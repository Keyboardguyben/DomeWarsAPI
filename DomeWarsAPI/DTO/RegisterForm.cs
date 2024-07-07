using System.ComponentModel.DataAnnotations;

namespace DomeWarsAPI.DTO
{
    public class RegisterForm
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8)]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",
        ErrorMessage = "Le mot de passe doit contenir minimum : 8 caractères, 1 Majuscule, 1 Minuscule et un symbole ")]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Les champs entrés doivent être identiques")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
