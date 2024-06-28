using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDomain.Entities
{
    public class Business
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(30)]
        public string Type { get; set; } = null!;
        [DefaultValue(0)]
        public int Funds {  get; set; }
        public int TerritoryId { get; set; }
        public Territory Territory { get; set; } = null!;

    }
}
