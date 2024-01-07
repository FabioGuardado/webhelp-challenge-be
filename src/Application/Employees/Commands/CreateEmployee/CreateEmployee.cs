using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Domain.Entities;

namespace WebhelpChallengeBackend.Application.Employees.Commands.CreateEmployee;
public record CreateEmployeeCommand : IRequest
{
    public EmployeeCreationDto? incomingEmployee { get; set; }
}

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateEmployeeCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {

        if (request.incomingEmployee != null)
        {
            var newEmployee = _mapper.Map<EmployeeCreationDto, Empleado>(request.incomingEmployee);
            _context.Empleados.Add(newEmployee);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
