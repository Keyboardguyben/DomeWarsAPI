using DomeWarsDomain.Entities;
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
        public string Name { get; set; } = null!;
        public int Hp {  get; set; }
        public int Dmg { get; set; }
        public int GangId { get; set; }
        public Gang Gang { get; set; } = null!;
        public int? TerritoryId {  get; set; }
        public Territory? Territory { get; set; }

    }
}
