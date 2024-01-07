using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Dtos;
public class EmployeeDto
{
    public int Id { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public TipoDeDocumentoDto? TipoDeDocumento { get; set; }
    public string? NumeroDeDocumento { get; set; }
    public DateOnly FechaDeContratacion { get; set; }
    public CountryDto? Pais { get; set; }
    public AreaDto? Area { get; set; }
    public SubAreaDto? SubArea { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Empleado, EmployeeDto>();
        }
    }
}
