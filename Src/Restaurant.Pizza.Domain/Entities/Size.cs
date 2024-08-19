using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Size : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}