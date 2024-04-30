using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class InfrastructureDIRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddDbContext<BlogDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("cleanarchskeletionDb"), o => o.EnableRetryOnFailure()));

            _ = services.AddScoped(typeof(IRepository<>), typeof(IRepository<>));

            return services;
        }
    }
}
