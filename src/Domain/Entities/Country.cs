﻿namespace WebhelpChallengeBackend.Domain.Entities;
public class Country : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Area>? Areas { get; set; }
}
