using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Repositories
{
    public interface IBusinessRepository
    {
        Business? GetById(int id);
        void NewGame(Business game);
        IEnumerable<Business> GetAll();
        void Delete(int id);
    }
}
