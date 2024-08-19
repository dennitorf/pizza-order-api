using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Offer : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Size Size { get; set; }
        public int MinToppings { get; set; }
        public int MinToppingsPerPizza { get; set; }
        public int MinPizza { get; set; }
        public double Discount { get; set; }
        public double PercentDiscount { get; set; }
    }
}