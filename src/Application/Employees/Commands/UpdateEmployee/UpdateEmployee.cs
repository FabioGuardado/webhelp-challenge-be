using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Employees.Commands.UpdateEmployee;
public record UpdateEmployeeCommand : IRequest
{
    public EmployeeCreationDto? IncomingEmployee { get; set; }
}

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateEmployeeCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        if (request.IncomingEmployee == null)
        {
            return;
        }

        var employeeToEdit = await _context.Employees.SingleOrDefaultAsync(e => e.Id == request.IncomingEmployee.Id);
        Guard.Against.NotFound(request.IncomingEmployee.Id, employeeToEdit);

        var employeeEdited = _mapper.Map(request.IncomingEmployee, employeeToEdit);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
