using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomeWarsDomain.Entities;

namespace DomeWarsBLL.Interfaces.Repositories
{
    public interface IGameRepository
    {
        Game? GetById(int id);
        void NewGame(Game game);
        public void Update(Game game);
        IEnumerable<Game> GetAll();
        IEnumerable<Game> GetNonStarted();
        int GetPlayerCount(int id);
        void Delete(int id);


    }
}
