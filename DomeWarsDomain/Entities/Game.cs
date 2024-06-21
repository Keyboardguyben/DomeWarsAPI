using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Password { get; set; }
        public int Round {  get; set; }
        public int? MaxRound {  get; set; }
        public int PlayerNumber {  get; set; }
        public int? WinnerId { get; set; }
    }
}
