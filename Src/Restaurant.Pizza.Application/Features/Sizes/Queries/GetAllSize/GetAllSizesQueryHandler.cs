using AutoMapper;
using Restaurant.Pizza.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.Pizza.Application.Features.Sizes.Queries.GetAllSize
{
    public class GetAllSizesQueryHandler(AppDbContext db, ILogger<GetAllSizesQueryHandler> logger, IMapper mapper) : IRequestHandler<GetAllSizesQuery, IEnumerable<SizeDto>>
    {
        private readonly AppDbContext db = db;
        private readonly ILogger logger = logger;
        private readonly IMapper mapper = mapper;

        public async Task<IEnumerable<SizeDto>> Handle(GetAllSizesQuery request, CancellationToken cancellationToken)
        {
            this.logger.LogInformation("Getting all pizza sizes");
            return await mapper.ProjectTo<SizeDto>(db.Sizes.AsNoTracking()).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
