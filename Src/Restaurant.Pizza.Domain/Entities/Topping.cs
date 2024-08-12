using System.Collections.Generic;
using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Topping : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int ToppingTypeId { get; set; }
        public ToppingType ToppingType { get; set; }

        public ICollection<Pizza> Pizzas { get; set; }
    }
}