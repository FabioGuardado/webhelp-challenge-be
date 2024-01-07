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
        builder.Property(a => a.Nombre)
            .IsRequired();

        builder.HasData(
                    new Area { Id = 1, Nombre = "Finanzas" },
                    new Area { Id = 2, Nombre = "Talento Humano" },
                    new Area { Id = 3, Nombre = "Mercadeo" },
                    new Area { Id = 4, Nombre = "Operaciones" },
                    new Area { Id = 5, Nombre = "Informática" }
                );
    }

}
