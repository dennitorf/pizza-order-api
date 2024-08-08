using AutoMapper;

namespace Restaurant.Pizza.Application.Common.Interfaces.Mappings
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
