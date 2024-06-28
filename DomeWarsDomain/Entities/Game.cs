using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public string? Password { get; set; }
        public int Round {  get; set; }
        public int? MaxRound {  get; set; }
        public int PlayerNumber {  get; set; }
        public int? PlayerId { get; set; }
        public Player? Player { get; set; }
        public List<Gang>? Gangs { get; set; }
    }
}
