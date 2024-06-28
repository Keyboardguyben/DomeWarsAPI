using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Gang
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Money { get; set; }
        public int PublicOpinion { get; set; }
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
        public List<Territory>? Territories { get; set; }


    }
}
