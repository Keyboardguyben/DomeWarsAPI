using System.ComponentModel.DataAnnotations;

namespace DomeWarsAPI.DTO
{
    public class AddGangForm
    {
        [Required]
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int GameId { get; set; }
        public int PlayerId { get; set; }
    }
}
