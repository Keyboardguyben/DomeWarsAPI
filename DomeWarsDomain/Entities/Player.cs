using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Username { get; set; } = null!;
        [MaxLength(100)]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public int Xp { get; set; }
        public List<Gang>? Gangs { get; set; }
    }
}
