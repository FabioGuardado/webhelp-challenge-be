
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Application.Employees.Commands.CreateEmployee;
public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateEmployeeCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(d => d.incomingEmployee)
            .NotNull()
            .MustAsync(BeUniqueDocumentNumber)
            .WithMessage("Document Number must be unique.")
            .WithErrorCode("Unique");
    }

    public async Task<bool> BeUniqueDocumentNumber(EmployeeCreationDto? incomingEmployee, CancellationToken cancellationToken)
    {
        if (incomingEmployee != null)
        {
            return await _context.Employees
            .Where(e => e.DocumentTypeId == incomingEmployee.DocumentTypeId)
            .AllAsync(e => e.DocumentNumber != incomingEmployee.DocumentNumber, cancellationToken);
        }

        return false;
    }
}
