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

        builder.HasData(
                    new Area { Id = 1, Name = "Finanzas" },
                    new Area { Id = 2, Name = "Talento Humano" },
                    new Area { Id = 3, Name = "Mercadeo" },
                    new Area { Id = 4, Name = "Operaciones" },
                    new Area { Id = 5, Name = "Informática" }
                );
    }

}
