using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDAL.Repositories
{
    public class BusinessRepository(DomeWarsContext dbContext) : IBusinessRepository
    {
        public void Delete(int id)
        {
            Business? business = dbContext.Business.SingleOrDefault(b => b.Id == id);
            if (business != null)
            {
                dbContext.Business.Remove(business);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Business> GetAll()
        {
            throw new NotImplementedException();
        }

        public Business? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Business>? GetByTerritory(int id) 
        {
            List<Business>? result =  dbContext.Business.Where(b => b.TerritoryId == id).ToList();
            return result;
        }

        public void CreateGameBusinesses(List<Territory> Map) 
        {
            List<Business> businesses = new List<Business>();
            Business business1 , business2;

            foreach (Territory territory in Map) 
            {
                switch (territory.LocationId)
                {
                    #region FillTerritories
                    // Industrial parc
                    case 1:
                    case 2:
                    case 5:
                    case 6:
                    case 7:
                    case 12:
                    case 37:
                    case 42:
                    case 43:
                    case 44:
                    case 47:
                    case 48:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Factory",
                            Name = "Usine"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Factory",
                            Name = "Entrepot"
                        };
                        businesses.Add(business2);
                        break;
                    // Black market
                    case 3:
                    case 4:
                    case 45:
                    case 46:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Illegal",
                            Name = "Maison close"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "RandomMoney",
                            Name = "Casino"
                        };
                        businesses.Add(business2);
                        break;
                    //Slums
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 13:
                    case 18:
                    case 31:
                    case 36:
                    case 38:
                    case 39:
                    case 40:
                    case 41:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Slum",
                            Name = "Taudis"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Slum",
                            Name = "Taudis"
                        };
                        businesses.Add(business2);
                        break;
                    //Commercial zone
                    case 14:
                    case 17:
                    case 32:
                    case 35:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Shop",
                            Name = "Magasin"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Shop",
                            Name = "Magasin"
                        };
                        businesses.Add(business2);
                        break;
                    //Residential zone
                    case 15:
                    case 16:
                    case 19:
                    case 20:
                    case 23: 
                    case 24: 
                    case 25:
                    case 26:
                    case 29: 
                    case 30:
                    case 33:
                    case 34:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Housing",
                            Name = "Appartement"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "Housing",
                            Name = "Complexe residentiel"
                        };
                        businesses.Add(business2);
                        break;
                    //City center
                    case 21:
                    case 22:
                    case 27:
                    case 28:
                        business1 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "AdvHousing",
                            Name = "Immeuble Appartement"
                        };
                        businesses.Add(business1);
                        business2 = new Business
                        {
                            TerritoryId = territory.Id,
                            Type = "AdvShop",
                            Name = "Banque"
                        };
                        businesses.Add(business2);
                        break;
                    #endregion

                    default:
                        break;

                }
            }

            dbContext.Business.AddRange(businesses);
            dbContext.SaveChanges();
        }

        public void DeleteMapBusinesses(List<Territory> Map) 
        {
            IEnumerable<Business>?  businesses = null;
            foreach (Territory territory in Map) {
                businesses = this.GetByTerritory(territory.Id);
                if (businesses != null)
                {
                    foreach (Business business in businesses) 
                    {
                        dbContext.Business.Remove(business);
                    }
                }
                dbContext.SaveChanges();
            }
        }
    }
}
