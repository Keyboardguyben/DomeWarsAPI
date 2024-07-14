using DomeWarsDomain.Entities;

namespace DomeWarsAPI.DTO
{
    public class CompleteTerritory : Territory
    {
        public string? GangName { get; set; }
        public string? GangColor { get; set; }
    }
}
