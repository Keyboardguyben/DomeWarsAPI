using DomeWarsDomain.Entities;
using Microsoft.Identity.Client;

namespace DomeWarsAPI.DTO
{
    public class TerritoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PoliceAttention { get; set; }
        public int? RoundsSinceAttack { get; set; }
        public bool IsAttacked { get; set; }
        public int LocalisationId { get; set; }
        public int? GangId { get; set; }
        public int? GameId { get; set; }


        public TerritoryDTO(Territory territory) {
            Id = territory.Id;
            Name = territory.Name;
            PoliceAttention = territory.PoliceAttention;
            RoundsSinceAttack = territory.RoundsSinceAttack;
            IsAttacked = territory.IsAttacked;
            GangId = territory.GangId;
            GameId = territory.GameId;
            LocalisationId = territory.LocationId;
        }
    }
}
