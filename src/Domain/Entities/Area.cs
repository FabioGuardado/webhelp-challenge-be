namespace WebhelpChallengeBackend.Domain.Entities;
public class Area : BaseEntity
{
    public string? Name { get; set; }
    public virtual Country? Country { get; set; }
    public int CountryId { get; set; }

    public ICollection<SubArea>? SubAreas { get; set; }
}
