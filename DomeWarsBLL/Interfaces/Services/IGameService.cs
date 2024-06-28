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
        void NewGame(Game game);
        IEnumerable<Game> GetAll();
        void Delete(int id);
    }
}
