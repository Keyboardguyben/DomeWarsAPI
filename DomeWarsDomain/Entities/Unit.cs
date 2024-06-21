using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Domain.Entities
{
    public class Unit
    {
        public int Id { get; set; }
        public int SoldierCount { get; set; }
        public string Name { get; set; }
        public int Hp {  get; set; }
        public int Dmg { get; set; }
        public int GangId { get; set; }
        public int TerritoryId {  get; set; }

    }
}
