using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDAL.Repositories
{
    public class TerritoryRepository(DomeWarsContext dbContext) : ITerritoryRepository
    {
        public void Add(Territory territory)
        {
            dbContext.Territory.Add(territory);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Territory> GetAll()
        {
            return dbContext.Set<Territory>().ToList();
        }

        public Territory? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Territory territory)
        {
            using (dbContext)
            {
                var result = dbContext.Territory.SingleOrDefault(t => t.Id == territory.Id);
                if (result != null)
                {
                    result.Name = territory.Name;
                    result.GangId = territory.GangId;
                    result.PoliceAttention = territory.PoliceAttention;
                    result.RoundsSinceAttack = territory.RoundsSinceAttack;
                    result.IsAttacked = territory.IsAttacked;
                    dbContext.SaveChanges();
                    return territory.Id;
                }
                else
                {
                    return (0);
                }
            }
        }
    }
}
