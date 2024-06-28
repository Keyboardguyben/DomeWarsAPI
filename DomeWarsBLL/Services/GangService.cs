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
    public class GangService(IGangRepository gangRepository) : IGangService
    {
        public void Delete(int id)
        {
            gangRepository.Delete(id);
        }

        public IEnumerable<Gang> GetAll()
        {
            return gangRepository.GetAll();
        }

        public Gang? GetById(int id)
        {
            return gangRepository.GetById(id);
        }

        public void NewGang(Gang game)
        {
            gangRepository.NewGang(game);
        }
    }
}
