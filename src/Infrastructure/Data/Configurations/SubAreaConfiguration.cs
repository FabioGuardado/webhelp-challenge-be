using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class SubAreaConfiguration : IEntityTypeConfiguration<SubArea>
{
    public void Configure(EntityTypeBuilder<SubArea> builder)
    {
        builder.Property(sa => sa.Name)
            .IsRequired();

        builder.HasData(
                new SubArea { Id = 1, Name = "Financiamiento" },
                new SubArea { Id = 2, Name = "Auditoría" },
                new SubArea { Id = 3, Name = "Contrataciones" },
                new SubArea { Id = 4, Name = "Capacitación y Desarrollo" },
                new SubArea { Id = 5, Name = "Ventas" },
                new SubArea { Id = 6, Name = "Publicidad" },
                new SubArea { Id = 7, Name = "Gestión de Proveedores" },
                new SubArea { Id = 8, Name = "Inventario" },
                new SubArea { Id = 9, Name = "Planificación" },
                new SubArea { Id = 10, Name = "Soporte Técnico" },
                new SubArea { Id = 11, Name = "Desarrollo de Software y Bases de Datos" },
                new SubArea { Id = 12, Name = "Redes e Infraestructura" }
            );
    }
}
