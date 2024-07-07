using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDAL.Configurations
{
    internal class BusinessConfig : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.HasOne(b => b.Territory)
                   .WithMany()
                   .HasForeignKey(b => b.TerritoryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
