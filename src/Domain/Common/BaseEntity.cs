using System.ComponentModel.DataAnnotations.Schema;

namespace WebhelpChallengeBackend.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }

}
