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
    public class TerritoryService(ITerritoryRepository territoryRepository) : ITerritoryService
    {
        public void Add(Territory territory)
        {
            territoryRepository.Add(territory);
        }

        public void Delete(int id)
        {
            territoryRepository.Delete(id);
        }

        public IEnumerable<Territory> GetAll()
        {
            return territoryRepository.GetAll();
        }

        public Territory? GetById(int id)
        {
            return territoryRepository.GetById(id);
        }

        public int Update(Territory territory)
        {
            return territoryRepository.Update(territory);
        }
    }
}
