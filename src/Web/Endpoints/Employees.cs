
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Application.Employees.Queries.GetAllEmployees;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class Employees : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllEmployees);
    }

    public async Task<PaginatedList<EmployeeDto>> GetAllEmployees(ISender sender, [AsParameters] GetAllEmployeesQuery query)
    {
        return await sender.Send(query);
    }
}
