﻿using System.Reflection;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Domain.Entities;
using WebhelpChallengeBackend.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebhelpChallengeBackend.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Country> Countries => Set<Country>();
    public DbSet<Area> Areas => Set<Area>();
    public DbSet<SubArea> SubAreas => Set<SubArea>();
    public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
