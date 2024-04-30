using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.Extensions
{
    public static class ApplicationDIRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            // add our dependency
            _ = services.AddAutoMapper(Assembly.GetExecutingAssembly());
            _ = services.AddMediatR(m => m.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())); // 1 by 1 ??
            return services;
        }
    }
}
