using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Pizza.Domain.Common;

namespace Restaurant.Pizza.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string CustomerName { get; set; }
        public decimal Total { get; set; } 
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; } 
        public ICollection<Pizza> Pizzas { get; set; } 
    }
}