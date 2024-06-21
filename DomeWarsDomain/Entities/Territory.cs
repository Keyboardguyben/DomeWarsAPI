using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Territory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PoliceAttention { get; set; }
        public int? RoundsSinceAttack { get; set; }
        public bool IsAttacked { get; set; }
        public int GangId { get; set; }
        public int GameId { get; set; }

    }
}
