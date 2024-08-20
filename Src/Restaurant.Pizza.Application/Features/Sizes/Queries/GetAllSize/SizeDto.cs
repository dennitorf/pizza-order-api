using Restaurant.Pizza.Application.Common.Interfaces.Mappings;
using Restaurant.Pizza.Domain.Entities;
using System;

namespace Restaurant.Pizza.Application.Features.Sizes.Queries.GetAllSize
{
    public class SizeDto : IMapFrom<Size>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}