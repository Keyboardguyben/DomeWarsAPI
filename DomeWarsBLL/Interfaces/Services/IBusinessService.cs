using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Services
{
    public interface IBusinessService
    {
        Business? GetById(int id);
        IEnumerable<Business> GetAll();
        void Delete(int id);
        public List<Business>? GetByTerritory(int id);
        public void DeleteMapBusinesses(List<Territory> Map);
        public void CreateGameBusinesses(List<Territory> Map);
    }
}
