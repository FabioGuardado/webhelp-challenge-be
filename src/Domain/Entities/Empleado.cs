namespace WebhelpChallengeBackend.Domain.Entities;
public class Empleado : BaseEntity
{
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public TipoDeDocumento? TipoDeDocumento { get; set; }
    public int TipoDeDocumentoId { get; set; }
    public string? NumeroDeDocumento { get; set; }
    public DateOnly FechaDeContratacion { get; set; }
    public Pais? Pais { get; set; }
    public int PaisId { get; set; }
    public Area? Area { get; set; }
    public int AreaId { get; set; }
    public SubArea? SubArea { get; set; }
    public int SubAreaId { get; set; }
}
