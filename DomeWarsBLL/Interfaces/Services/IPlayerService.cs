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
        //void Add(Player player);
        //Player? GetById(int id);
        //int Update(Player player);
        //IEnumerable<Player> GetAll();
        //void Delete(int id);
        public void Register(Player player, string password);
        public void Update(Player player);
        public Player Login(string email, string password);
        public string GetHashPwd(string email);
        //Pour vérifier si l'adresse mail correspond avec l'adresse mail de la DB de l'API AFTT créer le rôle admin
        public void IsAdmin(string email);
    }
}
