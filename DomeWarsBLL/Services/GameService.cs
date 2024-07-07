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

        public Game? GetById(int id)
        {
            return gameRepository.GetById(id);
        }

        public void NewGame(Game game)
        {
            gameRepository.NewGame(game);
            territoryService.MakeMap(game.Id);
            businessService.CreateGameBusinesses(territoryService.GetByGame(game.Id));
        }
    }
}
