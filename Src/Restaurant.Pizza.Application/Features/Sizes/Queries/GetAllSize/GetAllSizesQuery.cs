using MediatR;
using System.Collections.Generic;

namespace Restaurant.Pizza.Application.Features.Sizes.Queries.GetAllSize
{
    public class GetAllSizesQuery : IRequest<IEnumerable<SizeDto>>
    {
        public int Id { set; get; }

        public string Code { set; get; }
    }
}
