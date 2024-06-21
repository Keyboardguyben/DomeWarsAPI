using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomeWarsDomain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace DomeWarsDAL.Configurations
{
    internal class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(p => p.Username)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(p => p.Username)
                .IsUnique()
                .IsDescending();
            builder.Property(p => p.Password)
                .IsRequired();
            builder.Property(p => p.Role)
                .HasDefaultValue("User");
            builder.Property(p => p.Email)
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(p => p.Xp)
                .HasDefaultValue(0);
            

        }
    }
}
