using System.ComponentModel.DataAnnotations;

namespace DomeWarsAPI.DTO
{
    public class AddGangForm
    {
        [Required]
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}
