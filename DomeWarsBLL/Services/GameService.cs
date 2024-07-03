﻿using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Services
{
    public class GameService(IGameRepository gameRepository , ITerritoryRepository territoryRepository) : IGameService
    {
        public void Delete(int id)
        {
            territoryRepository.DeleteByGame(id);
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
            territoryRepository.MakeMap(game.Id);
        }
    }
}
