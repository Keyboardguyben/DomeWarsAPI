using DomeWarsDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsDAL.Configurations
{
    internal class GangConfig : IEntityTypeConfiguration<Gang>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Gang> builder)
        {
            throw new NotImplementedException();
        }
    }
}
