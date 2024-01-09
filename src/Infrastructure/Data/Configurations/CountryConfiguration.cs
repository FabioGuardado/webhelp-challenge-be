using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(p => p.Name)
            .IsRequired();

        builder.HasData(
                new Country { Id = 1, Name = "Guatemala" },
                new Country { Id = 2, Name = "El Salvador" },
                new Country { Id = 3, Name = "Costa Rica" }
            );
    }
}
