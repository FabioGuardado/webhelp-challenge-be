using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Infrastructure.Data.Configurations;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.FirstName)
            .IsRequired();

        builder.Property(e => e.LastNames)
            .IsRequired();

        builder.Property(e => e.DocumentNumber)
            .IsRequired();

        builder.HasData(
                new Employee { Id = 1, FirstName = "Fabio Ernesto", LastNames = "Guardado Gil", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 2, DocumentNumber = "062094829", CountryId = 1, AreaId = 3, SubAreaId = 14 },
                new Employee { Id = 2, FirstName = "Kevin Armando", LastNames = "Grande Chávez", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 1, DocumentNumber = "062359236", CountryId = 2, AreaId = 5, SubAreaId = 7 },
                new Employee { Id = 3, FirstName = "Kimberly Aronet", LastNames = "Vásquez Rodriguez", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 1, DocumentNumber = "123658522", CountryId = 2, AreaId = 4, SubAreaId = 3 },
                new Employee { Id = 4, FirstName = "Nelson Alberto", LastNames = "Serrano López", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 2, DocumentNumber = "0623598456", CountryId = 3, AreaId = 8, SubAreaId = 9 },
                new Employee { Id = 5, FirstName = "Mónica Alejandra", LastNames = "Reyes Ramos", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 1, DocumentNumber = "555141659", CountryId = 2, AreaId = 6, SubAreaId = 13 },
                new Employee { Id = 6, FirstName = "Alejandro Andrés", LastNames = "Nuila Santos", HiringDate = DateOnly.FromDateTime(DateTime.Now), DocumentTypeId = 2, DocumentNumber = "654658987", CountryId = 1, AreaId = 1, SubAreaId = 2 }
            );
    }
}
