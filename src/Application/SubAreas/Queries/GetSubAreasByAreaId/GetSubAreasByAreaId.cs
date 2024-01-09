using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhelpChallengeBackend.Application.Common.Interfaces;
using WebhelpChallengeBackend.Application.Common.Mappings;
using WebhelpChallengeBackend.Application.Common.Models;
using WebhelpChallengeBackend.Application.Dtos;

namespace WebhelpChallengeBackend.Application.SubAreas.Queries.GetSubAreasByAreaId;
public record GetSubAreasByAreaIdQuery : IRequest<List<SubAreaDto>>
{
    public int AreaId { get; set; }
}

public class GetSubAreasByAreaIdQueryHandler : IRequestHandler<GetSubAreasByAreaIdQuery, List<SubAreaDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetSubAreasByAreaIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<SubAreaDto>> Handle(GetSubAreasByAreaIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.SubAreas
            .Where(sa => sa.AreaId == request.AreaId)
            .ProjectToListAsync<SubAreaDto>(_mapper.ConfigurationProvider);
    }
}

