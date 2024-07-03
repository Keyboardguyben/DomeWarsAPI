﻿using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Repositories
{
    public interface ITerritoryRepository
    {
        void Add(Territory territory);
        Territory? GetById(int id);
        int Update(Territory territory);
        IEnumerable<Territory> GetAll();
        void Delete(int id);
        void MakeMap(int GameID);
        public void DeleteByGame(int GameID);
        public IEnumerable<Territory> GetByGame(int GameID);
    }
}
