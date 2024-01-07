﻿using System;
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
                new Country { Id = 1, Name = "Canadá" },
                new Country { Id = 2, Name = "Estados Unidos" },
                new Country { Id = 3, Name = "México" },
                new Country { Id = 4, Name = "Guatemala" },
                new Country { Id = 5, Name = "Belice" },
                new Country { Id = 6, Name = "El Salvador" },
                new Country { Id = 7, Name = "Honduras" },
                new Country { Id = 8, Name = "Nicaragua" },
                new Country { Id = 9, Name = "Costa Rica" },
                new Country { Id = 10, Name = "Panamá" }
            );
    }
}
