using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Services
{
    public interface IGangService
    {
        Gang? GetById(int id);
        void NewGang(Gang game);
        IEnumerable<Gang> GetAll();
        void Delete(int id);
        public List<Gang> GetGameGangs(int Gameid);
    }
}
