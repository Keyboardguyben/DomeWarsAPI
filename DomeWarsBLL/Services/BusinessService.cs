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
    public class BusinessService(IBusinessRepository businessRepository) : IBusinessService
    {
        public void CreateGameBusinesses(List<Territory> Map)
        {
            businessRepository.CreateGameBusinesses(Map);
        }

        public void Delete(int id)
        {
            businessRepository.Delete(id);
        }

        public void DeleteMapBusinesses(List<Territory> Map)
        {
            DeleteMapBusinesses(Map);
        }

        public IEnumerable<Business> GetAll()
        {
            return businessRepository.GetAll();
        }

        public Business? GetById(int id)
        {
            return businessRepository.GetById(id);
        }

        public List<Business>? GetByTerritory(int id)
        {
            return businessRepository.GetByTerritory(id);
        }

    }
}
