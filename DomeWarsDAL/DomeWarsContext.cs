using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomeWarsDomain.Entities;
using DomeWarsDAL.Configurations;
using DemoEF.Domain.Entities;

namespace DomeWarsDAL
{
    public class DomeWarsContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Gang> Gang { get; set; }
        public DbSet<Territory> Territory { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Business> Business { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=GOS-VDI904\TFTIC;Initial Catalog=DomeWars;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new PlayerConfig())
                .ApplyConfiguration(new TerritoryConfig())
                .ApplyConfiguration(new GameConfig())
                .ApplyConfiguration(new BusinessConfig());
        }
    }
}
