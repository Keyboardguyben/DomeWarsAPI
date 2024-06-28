using DomeWarsDomain.Entities;

namespace DomeWarsAPI.DTO
{
    public class GangDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Money { get; set; }
        public int PublicOpinion { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }

        public GangDTO(Gang gang) {
        Id = gang.Id;
            Name = gang.Name;
            Color = gang.Color;
            Money = gang.Money;
            PublicOpinion = gang.PublicOpinion;
            PlayerId = gang.PlayerId;
            GameId = gang.GameId;
        }
    }
}
