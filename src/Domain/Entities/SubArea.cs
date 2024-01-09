namespace WebhelpChallengeBackend.Domain.Entities;
public class SubArea : BaseEntity
{
    public string? Name { get; set; }
    public virtual Area? Area { get; set; }
    public int AreaId { get; set; }
}
