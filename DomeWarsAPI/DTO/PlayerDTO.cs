using DomeWarsDomain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DomeWarsAPI.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public int Xp { get; set; }

        public PlayerDTO(Player player)
        {
            Id = player.Id;
            Username = player.Username;
            Email = player.Email;
            Password = player.Password;
            Role = player.Role;
            Xp = player.Xp;
        }
    }
}
