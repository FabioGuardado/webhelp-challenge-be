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
    public string? FirstName { get; set; }
    public string? LastNames { get; set; }
    public DocumentTypeDto? DocumentType { get; set; }
    public string? DocumentNumber { get; set; }
    public DateOnly HiringDate { get; set; }
    public CountryDto? Country { get; set; }
    public AreaDto? Area { get; set; }
    public SubAreaDto? SubArea { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
