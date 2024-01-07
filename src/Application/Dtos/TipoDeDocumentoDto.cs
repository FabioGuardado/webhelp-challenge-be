using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Dtos;
public class TipoDeDocumentoDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TipoDeDocumento, TipoDeDocumentoDto>();
        }
    }
}
