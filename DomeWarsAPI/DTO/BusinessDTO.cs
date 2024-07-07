using DomeWarsDomain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DomeWarsAPI.DTO
{
    public class BusinessDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Funds { get; set; }
        public int TerritoryId { get; set; }

        public BusinessDTO(Business business) {
            Id = business.Id;
            Name = business.Name;
            Type = business.Type;
            Funds = business.Funds;
            TerritoryId = business.TerritoryId;
        }
    }
}
