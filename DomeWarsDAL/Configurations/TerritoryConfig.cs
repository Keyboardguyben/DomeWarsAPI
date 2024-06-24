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
    internal class TerritoryConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            //builder.HasOne(t => t.Gang)
            //       .WithMany()
            //       .HasForeignKey(t => t.GangId)
            //       .IsRequired()
            //       .OnDelete(DeleteBehavior.Cascade);
            builder.Property(t => t.Name)
                   .HasMaxLength(30);
                   
                   //.WithMany(mp => mp.Biographie)
                   //.HasForeignKey(fk => fk.PersonneId).IsRequired(false)
                   //.OnDelete(DeleteBehavior.Cascade);
        }
    }
}
