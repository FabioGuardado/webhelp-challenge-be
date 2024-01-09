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
    public string? searchString { get; set; }
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
        var keyword = "%" + request.searchString + "%";
        return await _context.Employees
            .Include(e => e.Area)
            .Include(e => e.SubArea)
            .Include(e => e.Country)
            .Include(e => e.DocumentType)
            .Where(e => EF.Functions.Like(e.FirstName, keyword) || EF.Functions.Like(e.LastNames, keyword) || EF.Functions.Like(e.DocumentNumber, keyword))
            .ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
