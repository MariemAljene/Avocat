using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class SpecialiteConfiguration : IEntityTypeConfiguration<Specialite>
    {
        public void Configure(EntityTypeBuilder<Specialite> builder)
        {
            builder.HasMany(t=>t.Avocats).WithOne(t=>t.Specialite).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
