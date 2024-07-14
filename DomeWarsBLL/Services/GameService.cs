using DomeWarsBLL.DTO;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Services
{
    public class GameService(IGameRepository gameRepository , ITerritoryService territoryService , IBusinessService businessService) : IGameService
    {
        public void Delete(int id)
        {
            territoryService.DeleteByGame(id);
            gameRepository.Delete(id);
        }

        public IEnumerable<Game> GetAll()
        {
            return gameRepository.GetAll();
        }

        public IEnumerable<Game> GetNonStarted() 
        {
            return gameRepository.GetNonStarted();
        }

        public Game? GetById(int id)
        {
            return gameRepository.GetById(id);
        }

        public int NewGame(Game game)
        {
            int id = gameRepository.NewGame(game);
            territoryService.MakeMap(game.Id);
            businessService.CreateGameBusinesses(territoryService.GetByGame(game.Id));
            return id;
        }

        public void Update(Game game)
        {
            gameRepository.Update(game);
        }

        public int GetPlayerCount(int id)
        {
            return gameRepository.GetPlayerCount(id);
        }
    }
}
