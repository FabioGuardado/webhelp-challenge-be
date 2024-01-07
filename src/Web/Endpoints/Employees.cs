
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Application.Employees.Commands.CreateEmployee;
using WebhelpChallengeBackend.Application.Employees.Commands.UpdateEmployee;
using WebhelpChallengeBackend.Application.Employees.Queries.GetAllEmployees;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class Employees : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllEmployees)
            .MapPost(CreateEmployee)
            .MapPut(UpdateEmployee, "{id}");
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
    public async Task<IResult> UpdateEmployee(ISender sender, int id, UpdateEmployeeCommand command)
    {
        if (command.IncomingEmployee == null)
        {
            return Results.BadRequest();
        }

        command.IncomingEmployee.Id = id;

        await sender.Send(command);
        return Results.NoContent();
    }

}
