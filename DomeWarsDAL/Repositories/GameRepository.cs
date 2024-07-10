using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace DomeWarsDAL.Repositories
{
    public class GameRepository(DomeWarsContext dbContext) : IGameRepository
    {
        public void Delete(int id)
        {
            Game? game = dbContext.Game.SingleOrDefault(g => g.Id == id);
            if (game != null)
            {
                dbContext.Game.Remove(game);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Game> GetAll()
        {
            return dbContext.Set<Game>().ToList();
        }
        public IEnumerable<Game> GetNonStarted() 
        {
            return dbContext.Set<Game>().Where(g => g.Round == 0).ToList();
        }

        public Game? GetById(int id)
        {

            return dbContext.Set<Game>().Find(id);
            
        }

        public void Update(Game game) 
        {
            Game? dbGame = dbContext.Game.SingleOrDefault(g => g.Id == game.Id);
            if (dbGame != null)
            {
                dbGame = game;
                dbContext.SaveChanges(true);
            }
            
        }

        public void NewGame(Game game)
        {
            dbContext.Game.Add(game);
            dbContext.SaveChanges();
        }

        public int GetPlayerCount(int id)
        {
            return dbContext.Gang.Where(g => g.GameId == id).Count();
        }
    }
}
