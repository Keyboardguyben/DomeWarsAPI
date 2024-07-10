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
    public class GangService(IGangRepository gangRepository , IGameRepository gameRepository) : IGangService
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

        public void NewGang(Gang gang)
        {
            Game? g = gameRepository.GetById(gang.GameId);
            if (g != null)
            {
                if (g.PlayerNumber > g.PlayersInGame)
                {
                    g.PlayersInGame = g.PlayersInGame + 1;
                    gameRepository.Update(g);
                    gangRepository.NewGang(gang);
                }
                else
                {
                    throw new Exception("La game est pleine");
                }
            }
            
        }
    }
}
