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
        builder.Property(sa => sa.Nombre)
            .IsRequired();

        builder.HasData(
                new SubArea { Id = 1, Nombre = "Financiamiento" },
                new SubArea { Id = 2, Nombre = "Auditoría" },
                new SubArea { Id = 3, Nombre = "Contrataciones" },
                new SubArea { Id = 4, Nombre = "Capacitación y Desarrollo" },
                new SubArea { Id = 5, Nombre = "Ventas" },
                new SubArea { Id = 6, Nombre = "Publicidad" },
                new SubArea { Id = 7, Nombre = "Gestión de Proveedores" },
                new SubArea { Id = 8, Nombre = "Inventario" },
                new SubArea { Id = 9, Nombre = "Planificación" },
                new SubArea { Id = 10, Nombre = "Soporte Técnico" },
                new SubArea { Id = 11, Nombre = "Desarrollo de Software y Bases de Datos" },
                new SubArea { Id = 12, Nombre = "Redes e Infraestructura" }
            );
    }
}
