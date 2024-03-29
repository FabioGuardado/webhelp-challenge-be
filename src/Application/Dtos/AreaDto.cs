﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Dtos;
public class AreaDto
{
    public int Id { get; set; }
    public string? Name { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Area, AreaDto>();
        }
    }
}
