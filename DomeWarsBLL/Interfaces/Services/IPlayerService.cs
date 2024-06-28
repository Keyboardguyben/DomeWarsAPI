using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Services
{
    public interface IPlayerService
    {
        void Add(Player player);
        Player? GetById(int id);
        int Update(Player player);
        IEnumerable<Player> GetAll();
        void Delete(int id);
    }
}
