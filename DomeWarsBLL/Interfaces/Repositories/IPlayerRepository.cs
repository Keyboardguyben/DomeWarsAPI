using DomeWarsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        //void Add(Player player);
        //Player? GetById(int id);
        //int Update(Player player);
        //IEnumerable<Player> GetAll();
        //void Delete(int id);
        public void Register(Player player, string password);
        public void Update(Player player);
        public Player Login(string email, string password);
        public string GetHashPwd(string email);
        public void IsAdmin(string email);
    }
}
