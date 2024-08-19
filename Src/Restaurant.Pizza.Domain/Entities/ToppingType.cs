using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class ToppingType : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }                
    }
}