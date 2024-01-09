namespace WebhelpChallengeBackend.Domain.Entities;
public class Employee : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastNames { get; set; }
    public DocumentType? DocumentType { get; set; }
    public int DocumentTypeId { get; set; }
    public string? DocumentNumber { get; set; }
    public DateOnly HiringDate { get; set; }
    public Country? Country { get; set; }
    public int CountryId { get; set; }
    public Area? Area { get; set; }
    public int AreaId { get; set; }
    public SubArea? SubArea { get; set; }
    public int SubAreaId { get; set; }
}
