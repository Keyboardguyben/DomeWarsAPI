using DomeWarsBLL.DTO;
using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Services
{
    public interface ITerritoryService
    {
        void Add(Territory territory);
        Territory? GetById(int id);
        int Update(Territory territory);
        List<Territory> GetAll();
        void Delete(int id);
        public List<Territory> GetByGame(int GameID);
        public List<CompleteTerritory> GetFullMap(int GameID);
        void MakeMap(int GameID);
        public void DeleteByGame(int GameID);
    }
}
