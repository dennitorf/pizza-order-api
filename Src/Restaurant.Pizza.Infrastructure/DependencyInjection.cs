using Restaurant.Pizza.Application.Common.Interfaces.Email;
using Restaurant.Pizza.Infrastructure.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Restaurant.Pizza.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IEmailService, EmailService>();   

            return services;
        }
    }
}
