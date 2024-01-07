using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Empleado> Empleados { get; }

    DbSet<Pais> Paises { get; }
    DbSet<Area> Areas { get; }
    DbSet<SubArea> SubAreas { get; }
    DbSet<TipoDeDocumento> TiposDeDocumento { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
