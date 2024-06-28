using System.ComponentModel.DataAnnotations;

namespace DomeWarsAPI.DTO
{
    public class AddPlayerForm
    {
        [Required]
        [MaxLength(30)]
        public string Username { get; set; } = null!;
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;


    }
}
