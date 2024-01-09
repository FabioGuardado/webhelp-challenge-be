using WebhelpChallengeBackend.Application.DocumentTypes.Queries.GetAllDocumentTypes;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Web.Endpoints;

public class DocumentTypes : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetAllDocumentTypes);
    }

    public async Task<List<DocumentTypeDto>> GetAllDocumentTypes(ISender sender, [AsParameters] GetAllDocumentTypesQuery query)
    {
        return await sender.Send(query);
    }
}
