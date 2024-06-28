using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomeWarsBLL.Interfaces;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;

namespace DomeWarsDAL.Repositories
{
    public class PlayerRepository(DomeWarsContext dbContext) : IPlayerRepository
    {
        public void Add(Player player)
        {
            dbContext.Player.Add(player);
            dbContext.SaveChanges();
        }

        public IEnumerable<Player> GetAll()
        {
            return dbContext.Set<Player>().ToList();
        }

        public int Update(Player player) 
        {
            using (dbContext)
            {
                var result = dbContext.Player.SingleOrDefault(p => p.Id == player.Id);
                if (result != null)
                {
                    result.Username = player.Username;
                    result.Password = player.Password;
                    result.Role = player.Role;
                    result.Email = player.Email;
                    dbContext.SaveChanges();
                    return player.Id;
                }
                else 
                {
                    return (0);
                }
            }
        }

        public Player? GetById(int id)
        {
            return dbContext.Set<Player>().Find(id);
        }

        public void Delete(int id)
        {
            Player? player = dbContext.Player.SingleOrDefault(p =>p.Id == id);
            if (player != null) 
            {
                dbContext.Player.Remove(player);
                dbContext.SaveChanges();
            }
        }
    }
}
