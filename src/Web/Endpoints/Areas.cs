
using WebhelpChallengeBackend.Application.Areas.Queries.GetAreasByCountryId;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class Areas : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAreasByCountryId);
    }

    public async Task<List<AreaDto>> GetAreasByCountryId(ISender sender, [AsParameters] GetAreasByCountryIdQuery query)
    {
        return await sender.Send(query);
    }
}
