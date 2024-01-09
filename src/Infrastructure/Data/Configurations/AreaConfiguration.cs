using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.Property(a => a.Name)
            .IsRequired();

        builder.HasOne(a => a.Country)
            .WithMany(c => c.Areas)
            .HasForeignKey(a => a.CountryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
                    new Area { Id = 1, Name = "Finanzas", CountryId = 1 },
                    new Area { Id = 2, Name = "Talento Humano", CountryId = 1 },
                    new Area { Id = 3, Name = "Informática", CountryId = 1 },
                    new Area { Id = 4, Name = "Finanzas", CountryId = 2 },
                    new Area { Id = 5, Name = "Talento Humano", CountryId = 2 },
                    new Area { Id = 6, Name = "Operaciones", CountryId = 2 },
                    new Area { Id = 7, Name = "Finanzas", CountryId = 3 },
                    new Area { Id = 8, Name = "Mercadeo", CountryId = 3 }
                );
    }

}
