using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public List<Territory> GetAll()
        {
            return dbContext.Set<Territory>().ToList();
        }

        public Territory? GetById(int id)
        {
            Territory? territory = dbContext.Set<Territory>().Find(id);
            if (territory != null)
            {
                return territory;
            }
            return null;
        }

        public void MakeMap(int GameID)
        {
            List<Territory> Map1 = new List<Territory>();

            #region TerritoryCreation

            Territory territory1 = new Territory {
                Name = "Parc industriel",
                GameId = GameID ,  
                IsAttacked = false, 
                PoliceAttention = 0,
                LocationId = 1
            };
            Territory territory2 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 2
            };
            Territory territory3 = new Territory
            {
                Name = "Marché Noir",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 3
            };
            Territory territory4 = new Territory
            {
                Name = "Marché noir",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 4
            };
            Territory territory5 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 5
            };
            Territory territory6 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 6
            };
            Territory territory7 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 7
            };
            Territory territory8 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 8
            };
            Territory territory9 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 9
            };
            Territory territory10 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 10
            };
            Territory territory11 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 11
            };
            Territory territory12 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 12
            };
            Territory territory13 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 13
            };
            Territory territory14 = new Territory
            {
                Name = "Zone commerciale",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 14
            };
            Territory territory15 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 15
            };
            Territory territory16 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 16
            };
            Territory territory17 = new Territory
            {
                Name = "Zone commerciale",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 17
            };
            Territory territory18 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 18
            };
            Territory territory19 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 19
            };
            Territory territory20 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 20
            };
            Territory territory21 = new Territory
            {
                Name = "Centreville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 21
            };
            Territory territory22 = new Territory
            {
                Name = "Centreville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 22
            };
            Territory territory23 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 23
            };
            Territory territory24 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 24
            };
            Territory territory25 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 25 
            };
            Territory territory26 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 26
            };
            Territory territory27 = new Territory
            {
                Name = "Centreville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 27
            };
            Territory territory28 = new Territory
            {
                Name = "Centreville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 28
            };
            Territory territory29 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 29
            };
            Territory territory30 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 30
            };
            Territory territory31 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 31
            };
            Territory territory32 = new Territory
            {
                Name = "Zone commerciale",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 32

            };
            Territory territory33 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 33
            };
            Territory territory34 = new Territory
            {
                Name = "Zone résidentielle",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 34
            };
            Territory territory35 = new Territory
            {
                Name = "Zone commerciale",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 35
            };
            Territory territory36 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 36
            };
            Territory territory37 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 37
            };
            Territory territory38 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 38
            };
            Territory territory39 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 39
            };
            Territory territory40 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 40
            };
            Territory territory41 = new Territory
            {
                Name = "Bidonville",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 41
            };
            Territory territory42 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 42

            };
            Territory territory43 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 43
            };
            Territory territory44 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 44
            };
            Territory territory45 = new Territory
            {
                Name = "Marché noir",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 45
            };
            Territory territory46 = new Territory
            {
                Name = "Marché noir",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 46
            };
            Territory territory47 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 47
            };
            Territory territory48 = new Territory
            {
                Name = "Parc industriel",
                GameId = GameID,
                IsAttacked = false,
                PoliceAttention = 0,
                LocationId = 48
            };
            #endregion

            #region FillMap
            Map1.Add(territory1);
            Map1.Add(territory2);
            Map1.Add(territory3);
            Map1.Add(territory4);
            Map1.Add(territory5);
            Map1.Add(territory6);
            Map1.Add(territory7);
            Map1.Add(territory8);
            Map1.Add(territory9);
            Map1.Add(territory10);
            Map1.Add(territory11);
            Map1.Add(territory12);
            Map1.Add(territory13);
            Map1.Add(territory14);
            Map1.Add(territory15);
            Map1.Add(territory16);
            Map1.Add(territory17);
            Map1.Add(territory18);
            Map1.Add(territory19);
            Map1.Add(territory20);
            Map1.Add(territory21);
            Map1.Add(territory22);
            Map1.Add(territory23);
            Map1.Add(territory24);
            Map1.Add(territory25);
            Map1.Add(territory26);
            Map1.Add(territory27);
            Map1.Add(territory28);
            Map1.Add(territory29);
            Map1.Add(territory30);
            Map1.Add(territory31);
            Map1.Add(territory32);
            Map1.Add(territory33);
            Map1.Add(territory34);
            Map1.Add(territory35);
            Map1.Add(territory36);
            Map1.Add(territory37);
            Map1.Add(territory38);
            Map1.Add(territory39);
            Map1.Add(territory40);
            Map1.Add(territory41);
            Map1.Add(territory42);
            Map1.Add(territory43);
            Map1.Add(territory44);
            Map1.Add(territory45);
            Map1.Add(territory46);
            Map1.Add(territory47);
            Map1.Add(territory48);
            #endregion

            dbContext.Territory.AddRange(Map1);
            dbContext.SaveChanges();
        }

        public void DeleteByGame(int GameID)
        {
            dbContext.Territory.Where(t => t.GameId == GameID).ExecuteDelete();
        }

        public List<Territory> GetByGame(int GameID) 
        {
            return dbContext.Territory.Where(t => t.GameId == GameID).ToList();
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
