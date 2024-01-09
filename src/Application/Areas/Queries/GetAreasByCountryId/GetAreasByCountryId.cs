using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Common.Mappings;
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Application.Areas.Queries.GetAreasByCountryId;
public record GetAreasByCountryIdQuery : IRequest<List<AreaDto>>
{
    public int CountryId { get; set; }
}

public class GetAreasByCountryIdQueryHandler : IRequestHandler<GetAreasByCountryIdQuery, List<AreaDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAreasByCountryIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<AreaDto>> Handle(GetAreasByCountryIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.Areas
            .Where(a => a.CountryId == request.CountryId)
            .ProjectToListAsync<AreaDto>(_mapper.ConfigurationProvider);
    }
}

