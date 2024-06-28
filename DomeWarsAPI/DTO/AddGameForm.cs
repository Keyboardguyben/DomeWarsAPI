using DomeWarsDomain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DomeWarsAPI.DTO
{
    public class AddGameForm
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
        public string? Password { get; set; }
        public int? MaxRound { get; set; }
        public int PlayerNumber { get; set; }
    }
}
