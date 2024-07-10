using DomeWarsDomain.Entities;

namespace DomeWarsAPI.DTO
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Password { get; set; }
        public int Round { get; set; }
        public int? MaxRound { get; set; }
        public int PlayersInGame { get; set; }
        public int PlayerNumber { get; set; }
        public int? PlayerId { get; set; }

        public GameDTO(Game game) 
        {
            Id = game.Id;
            Name = game.Name;
            Password = game.Password;
            Round = game.Round;
            MaxRound = game.MaxRound;
            PlayersInGame = game.PlayersInGame;
            PlayerNumber = game.PlayerNumber;
            PlayerId = game.PlayerId;
        }
    }
}
