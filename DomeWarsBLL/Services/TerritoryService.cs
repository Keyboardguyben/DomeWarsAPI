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
    public class TerritoryService(ITerritoryRepository territoryRepository , IGangRepository gangRepository) : ITerritoryService
    {
        public void Add(Territory territory)
        {
            territoryRepository.Add(territory);
        }

        public void Delete(int id)
        {
            territoryRepository.Delete(id);
        }

        public void DeleteByGame(int GameID)
        {
            territoryRepository.DeleteByGame(GameID);
        }

        public List<Territory> GetAll()
        {
            return territoryRepository.GetAll();
        }

        public List<Territory> GetByGame(int GameID)
        {
            return territoryRepository.GetByGame(GameID);
        }

        public List<CompleteTerritory> GetFullMap(int GameID) 
        {
            List<CompleteTerritory> completeTerritories = new List<CompleteTerritory>();
            List<Territory> territories = territoryRepository.GetByGame(GameID);
            foreach(Territory territory in territories) {
                CompleteTerritory completeTerritory = new CompleteTerritory();
                completeTerritory.Id = territory.Id;
                completeTerritory.Name = territory.Name;
                completeTerritory.LocationId = territory.LocationId;
                completeTerritory.GameId = territory.GameId;
                completeTerritory.IsAttacked = territory.IsAttacked;
                completeTerritory.RoundsSinceAttack = territory.RoundsSinceAttack;       
                if(territory.GangId != null)
                {
                    completeTerritory.GangId = territory.GangId;
                    completeTerritory.gang = gangRepository.GetById(completeTerritory.GangId ?? default(int));
                }            
                completeTerritories.Add(completeTerritory);
            }
            return completeTerritories;
        }

        public Territory? GetById(int id)
        {
            return territoryRepository.GetById(id);
        }

        public void MakeMap(int GameID)
        {
            territoryRepository.MakeMap(GameID);
        }

        public int Update(Territory territory)
        {
            return territoryRepository.Update(territory);
        }
    }
}
