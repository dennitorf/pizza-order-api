using System.Collections.Generic;
using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Pizza : BaseEntity
    {
        public Size Size { get; set; }
        public ICollection<Topping> Toppings { get; set; }
        public decimal Price { get; set; }
        public decimal BeforePrice { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}