using System.Collections.Generic;
using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Pizza : BaseEntity
    {
        public Size Size { get; set; }
        public ICollection<Topping> Toppings { get; set; }
        public double Price { get; set; }
        public double BeforePrice { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }

    }
}