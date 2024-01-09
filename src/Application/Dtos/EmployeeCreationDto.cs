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
    public string? FirstName { get; set; }
    public string? LastNames { get; set; }
    public int DocumentTypeId { get; set; }
    public string? DocumentNumber { get; set; }
    public DateOnly HiringDate { get; set; }
    public int CountryId { get; set; }
    public int AreaId { get; set; }
    public int SubAreaId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee, EmployeeCreationDto>();
            CreateMap<EmployeeCreationDto, Employee>();
        }
    }
}
