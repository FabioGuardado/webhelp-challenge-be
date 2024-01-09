
using WebhelpChallengeBackend.Application.Dtos;
using WebhelpChallengeBackend.Application.SubAreas.Queries.GetSubAreasByAreaId;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class SubAreas : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetSubAreasByAreaId);
    }

    public async Task<List<SubAreaDto>> GetSubAreasByAreaId(ISender sender, [AsParameters] GetSubAreasByAreaIdQuery query)
    {
        return await sender.Send(query);
    }
}
