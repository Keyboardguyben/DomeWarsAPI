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
        IEnumerable<Game> GetAll();
        void Delete(int id);

    }
}
