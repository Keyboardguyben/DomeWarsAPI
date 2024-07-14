using DomeWarsBLL.DTO;
using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Services
{
    public interface IGameService
    {
        Game? GetById(int id);
        int NewGame(Game game);
        public void Update(Game game);
        IEnumerable<Game> GetAll();
        public IEnumerable<Game> GetNonStarted();
        void Delete(int id);
        public int GetPlayerCount(int id);
    }
}
