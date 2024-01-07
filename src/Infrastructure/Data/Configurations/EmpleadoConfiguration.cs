using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.Property(e => e.Nombres)
            .IsRequired();

        builder.Property(e => e.Apellidos)
            .IsRequired();

        builder.Property(e => e.NumeroDeDocumento)
            .IsRequired();

        builder.HasData(
                new Empleado { Id = 1, Nombres = "Fabio Ernesto", Apellidos = "Guardado Gil", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 1, NumeroDeDocumento = "062094829", PaisId = 6, AreaId = 5, SubAreaId = 11 },
                new Empleado { Id = 2, Nombres = "Kevin Armando", Apellidos = "Grande Chávez", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 1, NumeroDeDocumento = "062359236", PaisId = 6, AreaId = 5, SubAreaId = 10 },
                new Empleado { Id = 3, Nombres = "Kimberly Aronet", Apellidos = "Vásquez Rodriguez", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 1, NumeroDeDocumento = "123658522", PaisId = 6, AreaId = 4, SubAreaId = 9 },
                new Empleado { Id = 4, Nombres = "Nelson Alberto", Apellidos = "Serrano López", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 2, NumeroDeDocumento = "0623598456", PaisId = 7, AreaId = 1, SubAreaId = 1 },
                new Empleado { Id = 5, Nombres = "Mónica Alejandra", Apellidos = "Reyes Ramos", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 1, NumeroDeDocumento = "555141659", PaisId = 6, AreaId = 1, SubAreaId = 2 },
                new Empleado { Id = 6, Nombres = "Alejandro Andrés", Apellidos = "Nuila Santos", FechaDeContratacion = DateOnly.FromDateTime(DateTime.Now), TipoDeDocumentoId = 2, NumeroDeDocumento = "654658987", PaisId = 3, AreaId = 1, SubAreaId = 2 }
            );
    }
}
