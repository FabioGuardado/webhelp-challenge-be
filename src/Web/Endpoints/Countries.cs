using WebhelpChallengeBackend.Application.Countries.Queries.GetAllCountries;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class Countries : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllCountries);
    }

    public async Task<List<CountryDto>> GetAllCountries(ISender sender, [AsParameters] GetAllCountriesQuery query)
    {
        return await sender.Send(query);
    }
}
