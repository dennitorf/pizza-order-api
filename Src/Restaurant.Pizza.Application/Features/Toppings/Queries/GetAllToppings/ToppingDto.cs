using Restaurant.Pizza.Application.Common.Interfaces.Mappings;
using Restaurant.Pizza.Domain.Entities;


namespace Restaurant.Pizza.Application.Features.Toppings.Queries
{
    public class ToppingDto : IMapFrom<Topping>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ToppingTypeId { get; set; }
        public ToppingTypeDto ToppingType { get; set; }
    }
}