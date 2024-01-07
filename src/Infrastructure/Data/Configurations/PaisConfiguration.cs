using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.Property(p => p.Nombre)
            .IsRequired();

        builder.HasData(
                new Pais { Id = 1, Nombre = "Canadá" },
                new Pais { Id = 2, Nombre = "Estados Unidos" },
                new Pais { Id = 3, Nombre = "México" },
                new Pais { Id = 4, Nombre = "Guatemala" },
                new Pais { Id = 5, Nombre = "Belice" },
                new Pais { Id = 6, Nombre = "El Salvador" },
                new Pais { Id = 7, Nombre = "Honduras" },
                new Pais { Id = 8, Nombre = "Nicaragua" },
                new Pais { Id = 9, Nombre = "Costa Rica" },
                new Pais { Id = 10, Nombre = "Panamá" }
            );
    }
}
