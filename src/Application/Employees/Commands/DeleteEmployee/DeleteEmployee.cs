using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;

namespace WebhelpChallengeBackend.Application.Employees.Commands.DeleteEmployee;
public record DeleteEmployeeCommand(int Id) : IRequest;


public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteEmployeeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        var employeeToDelete = await _context.Empleados.SingleOrDefaultAsync(e => e.Id == request.Id);
        Guard.Against.NotFound(request.Id, employeeToDelete);

        _context.Empleados.Remove(employeeToDelete);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
