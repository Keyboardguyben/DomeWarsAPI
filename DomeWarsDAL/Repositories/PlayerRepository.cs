using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomeWarsBLL.Interfaces;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DomeWarsDAL.Repositories
{
    //public class PlayerRepository(DomeWarsContext dbContext) : IPlayerRepository
    //{
    //    public void Add(Player player)
    //    {
    //        dbContext.Player.Add(player);
    //        dbContext.SaveChanges();
    //    }

    //    public IEnumerable<Player> GetAll()
    //    {
    //        return dbContext.Set<Player>().ToList();
    //    }

    //    public int Update(Player player) 
    //    {
    //        using (dbContext)
    //        {
    //            var result = dbContext.Player.SingleOrDefault(p => p.Id == player.Id);
    //            if (result != null)
    //            {
    //                result.Username = player.Username;
    //                result.Password = player.Password;
    //                result.Role = player.Role;
    //                result.Email = player.Email;
    //                dbContext.SaveChanges();
    //                return player.Id;
    //            }
    //            else 
    //            {
    //                return (0);
    //            }
    //        }
    //    }

    //    public Player? GetById(int id)
    //    {
    //        return dbContext.Set<Player>().Find(id);
    //    }

    //    public void Delete(int id)
    //    {
    //        Player? player = dbContext.Player.SingleOrDefault(p =>p.Id == id);
    //        if (player != null) 
    //        {
    //            dbContext.Player.Remove(player);
    //            dbContext.SaveChanges();
    //        }
    //    }
    //}

    public class PlayerRepository : IPlayerRepository
    {
        private readonly string connectionString;
        public PlayerRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("default");
        }

        private Player Converter(SqlDataReader reader)
        {
            return new Player
            {
                Id = (int)reader["Id"],
                Username = (string)reader["Username"],
                Email = (string)reader["Email"],
                Role = (string)reader["Role"],
                Xp = (int)reader["Xp"]
            };
        }

        public string GetHashPwd(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Password] " +
                        "FROM [Player] WHERE Email = @email";

                    try
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("email", email);
                        string password = (string)cmd.ExecuteScalar();
                        connection.Close();
                        return password;
                    }
                    catch (SqlException ex)
                    {

                        throw ex;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        public void IsAdmin(string email)
        {
            throw new NotImplementedException();
        }

        public Player Login(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Email, Username " +
                        "FROM [Player] WHERE Email = @email AND Password = @pwd";


                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("pwd", password);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Player
                                {
                                    Id = (int)reader["Id"],
                                    Email = (string)reader["Email"],
                                    Username = (string)reader["Username"],
                                };
                            }
                            else throw new InvalidOperationException("Compte utilisateur inexistant");
                        }
                    }
                    catch (SqlException ex)
                    {

                        throw ex;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
            }
        }

        public void Register(Player player, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Player] (Username, Email, Password) " +
                                        "VALUES (@username, @email, @password)";


                    cmd.Parameters.AddWithValue("username", player.Username);
                    cmd.Parameters.AddWithValue("email", player.Email);
                    cmd.Parameters.AddWithValue("password", password);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {

                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public void Update(Player player)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [Player] SET Username = @Username " +
                        "WHERE Id = @id ";

                    cmd.Parameters.AddWithValue("id", player.Id);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {

                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
