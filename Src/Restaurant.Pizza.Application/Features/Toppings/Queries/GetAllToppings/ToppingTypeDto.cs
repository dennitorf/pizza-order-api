using Restaurant.Pizza.Application.Common.Interfaces.Mappings;
using Restaurant.Pizza.Domain.Entities;

namespace Restaurant.Pizza.Application.Features.Toppings.Queries
{
    public class ToppingTypeDto : IMapFrom<ToppingType>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }        
    }
}
