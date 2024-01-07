
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Application.Employees.Commands.CreateEmployee;
using WebhelpChallengeBackend.Application.Employees.Queries.GetAllEmployees;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class Employees : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllEmployees)
            .MapPost(CreateEmployee);
    }

    public async Task<PaginatedList<EmployeeDto>> GetAllEmployees(ISender sender, [AsParameters] GetAllEmployeesQuery query)
    {
        return await sender.Send(query);
    }

    public async Task<IResult> CreateEmployee(ISender sender, CreateEmployeeCommand command)
    {
        await sender.Send(command);
        return Results.Created();
    }

}
