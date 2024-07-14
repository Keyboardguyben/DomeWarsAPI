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
    public class GangService(IGangRepository gangRepository , IGameRepository gameRepository , ITerritoryRepository territoryRepository) : IGangService
    {
        public void Delete(int id)
        {
            gangRepository.Delete(id);
        }

        public IEnumerable<Gang> GetAll()
        {
            return gangRepository.GetAll();
        }

        public Gang? GetById(int id)
        {
            return gangRepository.GetById(id);
        }

        public List<Gang> GetGameGangs(int Gameid)
        {
            return gangRepository.GetGameGangs(Gameid);
        }

        public void NewGang(Gang gang)
        {
            Game? g = gameRepository.GetById(gang.GameId);
            int i;
            if (g != null)
            {
                if (g.PlayerNumber > g.PlayersInGame)
                {
                    g.PlayersInGame++;
                    gameRepository.Update(g);                                      
                    i = gangRepository.NewGang(gang);
                    List<Territory> territories = territoryRepository.GetByGame(gang.GameId);
                    Territory territory;
                    switch (g.PlayersInGame)
                    {
                        case 1:
                            territory = territories.Find(t => t.LocationId == 1);
                            territory.GangId = i;
                            territoryRepository.Update(territory);
                            break;
                        case 2:
                            territory = territories.Find(t => t.LocationId == 6);
                            territory.GangId = i;
                            territoryRepository.Update(territory);
                            break;
                        case 3:
                            territory = territories.Find(t => t.LocationId == 43);
                            territory.GangId = i;
                            territoryRepository.Update(territory);
                            break;
                        case 4:
                            territory = territories.Find(t => t.LocationId == 48);
                            territory.GangId = i;
                            territoryRepository.Update(territory);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    throw new Exception("La game est pleine");
                }
            }
            
        }
    }
}
