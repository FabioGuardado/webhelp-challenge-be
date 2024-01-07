using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Common.Mappings;
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Application.Employees.Queries.GetAllEmployees;
public record GetAllEmployeesQuery : IRequest<PaginatedList<EmployeeDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}

public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, PaginatedList<EmployeeDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllEmployeesQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
    {
        return await _context.Empleados
            .Include(e => e.Area)
            .Include(e => e.SubArea)
            .Include(e => e.Pais)
            .Include(e => e.TipoDeDocumento)
            .ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
