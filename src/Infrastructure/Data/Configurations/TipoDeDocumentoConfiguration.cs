using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class TipoDeDocumentoConfiguration : IEntityTypeConfiguration<TipoDeDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDeDocumento> builder)
    {
        builder.Property(t => t.Nombre)
            .IsRequired();

        builder.HasData(
                new TipoDeDocumento { Id = 1, Nombre = "DUI" },
                new TipoDeDocumento { Id = 2, Nombre = "Pasaporte" }
            );
    }
}
