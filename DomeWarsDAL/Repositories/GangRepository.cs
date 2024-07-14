using DomeWarsBLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomeWarsDAL.Repositories
{
    public class GangRepository(DomeWarsContext dbContext) : IGangRepository
    {
        public void Delete(int id)
        {
            Gang? gang = dbContext.Gang.SingleOrDefault(g => g.Id == id);
            if (gang != null)
            {
                dbContext.Gang.Remove(gang);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Gang> GetAll()
        {
            return dbContext.Set<Gang>().ToList();
        }

        public Gang? GetById(int id)
        {
            
            Gang? gang = dbContext.Set<Gang>().Find(id);
            if(gang != null) 
            {
                return gang;
            }
            return null;
        }

        public List<Gang> GetGameGangs(int Gameid)
        {
            List<Gang> gangs = dbContext.Gang.Where(g => g.GameId == Gameid).ToList();
            return gangs;
        }

        public int NewGang(Gang gang)
        {
            dbContext.Gang.Add(gang);         
            dbContext.SaveChanges();
            return gang.Id;
        }
    }
}
