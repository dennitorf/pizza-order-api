using AutoMapper;
using Restaurant.Pizza.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Restaurant.Pizza.Application.Features.Sizes.Queries.GetAllSize;

namespace Restaurant.Pizza.Application.Features.Toppings.Queries.GetAllToppings
{
    public class GetAllToppingsQueryHandler(AppDbContext db, ILogger<GetAllToppingsQueryHandler> logger, IMapper mapper) : IRequestHandler<GetAllToppingsQuery, IEnumerable<ToppingDto>>
    {
        private readonly AppDbContext db = db;
        private readonly ILogger logger = logger;
        private readonly IMapper mapper = mapper;

        public async Task<IEnumerable<ToppingDto>> Handle(GetAllToppingsQuery request, CancellationToken cancellationToken)
        {
           logger.LogInformation("Getting all toppings");
           return await mapper.ProjectTo<ToppingDto>(db.Toppings.AsNoTracking()).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}