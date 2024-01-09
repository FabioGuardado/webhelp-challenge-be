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

        builder.HasOne(s => s.Area)
            .WithMany(a => a.SubAreas)
            .HasForeignKey(s => s.AreaId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
                new SubArea { Id = 1, Name = "Financiamiento", AreaId = 1 },
                new SubArea { Id = 2, Name = "Auditoría", AreaId = 1 },
                new SubArea { Id = 3, Name = "Financiamiento", AreaId = 4 },
                new SubArea { Id = 4, Name = "Auditoría", AreaId = 7 },
                new SubArea { Id = 5, Name = "Contrataciones", AreaId = 2 },
                new SubArea { Id = 6, Name = "Capacitación y Desarrollo", AreaId = 2 },
                new SubArea { Id = 7, Name = "Contrataciones", AreaId = 5 },
                new SubArea { Id = 8, Name = "Capacitación y Desarrollo", AreaId = 5 },
                new SubArea { Id = 9, Name = "Ventas", AreaId = 8 },
                new SubArea { Id = 10, Name = "Publicidad", AreaId = 8 },
                new SubArea { Id = 11, Name = "Gestión de Proveedores", AreaId = 6 },
                new SubArea { Id = 12, Name = "Inventario", AreaId = 6 },
                new SubArea { Id = 13, Name = "Planificación", AreaId = 6 },
                new SubArea { Id = 14, Name = "Soporte Técnico", AreaId = 3 },
                new SubArea { Id = 15, Name = "Desarrollo de Software y Bases de Datos", AreaId = 3 },
                new SubArea { Id = 16, Name = "Redes e Infraestructura", AreaId = 3 }
            );
    }
}
