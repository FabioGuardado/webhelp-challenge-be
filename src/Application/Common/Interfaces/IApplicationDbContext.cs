using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Employee> Employees { get; }

    DbSet<Country> Countries { get; }
    DbSet<Area> Areas { get; }
    DbSet<SubArea> SubAreas { get; }
    DbSet<DocumentType> DocumentTypes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
