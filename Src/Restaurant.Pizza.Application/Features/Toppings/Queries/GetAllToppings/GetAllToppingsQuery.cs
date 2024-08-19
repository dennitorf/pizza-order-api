using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Restaurant.Pizza.Application.Features.Toppings.Queries.GetAllToppings
{
    public class GetAllToppingsQuery: IRequest<IEnumerable<ToppingDto>>
    {
        
    }
}