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
    public class PlayerService(IPlayerRepository playerRepository) : IPlayerService
    {
        //public void Add(Player player)
        //{
        //    playerRepository.Add(player);
        //}

        //public void Delete(int id)
        //{
        //    playerRepository.Delete(id);
        //}

        //public IEnumerable<Player> GetAll()
        //{
        //    return playerRepository.GetAll();
        //}

        //public Player? GetById(int id)
        //{
        //    return playerRepository.GetById(id);
        //}

        //public int Update(Player player)
        //{
        //    return (int)playerRepository.Update(player);
        //}
        public string GetHashPwd(string email)
        {
            return playerRepository.GetHashPwd(email);
        }

        public void IsAdmin(string email)
        {
            throw new NotImplementedException();
        }

        public Player Login(string email, string password)
        {
            string verifyPWD = playerRepository.GetHashPwd(email);
            if (BCrypt.Net.BCrypt.Verify(password, verifyPWD))
            {
                Player connecterUser = playerRepository.Login(email, verifyPWD);
                return connecterUser;
            }
            else
            {
                throw new InvalidOperationException("Mot de passe incorrect");
            }
        }

        public void Register(Player player, string password)
        {
            string hashPWD = BCrypt.Net.BCrypt.HashPassword(password);

            playerRepository.Register(player, hashPWD);
        }

        public void Update(Player player)
        {
            playerRepository.Update(player);
        }
    }
}
