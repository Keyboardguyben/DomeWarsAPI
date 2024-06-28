using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;

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

        public Game? GetById(int id)
        {

            return dbContext.Set<Game>().Find(id);
            
        }

        public void NewGame(Game game)
        {
            dbContext.Game.Add(game);
            dbContext.SaveChanges();
        }
    }
}
