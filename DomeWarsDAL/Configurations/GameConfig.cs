using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDAL.Configurations
{
    internal class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(g => g.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(g => g.PlayerNumber)
                .IsRequired();

            builder.Property(g => g.Password)
                .HasMaxLength(50);

            builder.Property(g => g.Round)
                .IsRequired()
                .HasDefaultValue(0);

        }
    }
}
