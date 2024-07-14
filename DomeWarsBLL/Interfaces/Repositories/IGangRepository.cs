using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Repositories
{
    public interface IGangRepository
    {
        Gang? GetById(int id);
        int NewGang(Gang game);
        IEnumerable<Gang> GetAll();
        void Delete(int id);
        public List<Gang> GetGameGangs(int Gameid);
    }
}
