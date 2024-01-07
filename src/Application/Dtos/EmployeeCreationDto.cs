using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Dtos;
public class EmployeeCreationDto
{
    public int Id { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public int TipoDeDocumentoId { get; set; }
    public string? NumeroDeDocumento { get; set; }
    public DateOnly FechaDeContratacion { get; set; }
    public int PaisId { get; set; }
    public int AreaId { get; set; }
    public int SubAreaId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Empleado, EmployeeCreationDto>();
            CreateMap<EmployeeCreationDto, Empleado>();
        }
    }
}
