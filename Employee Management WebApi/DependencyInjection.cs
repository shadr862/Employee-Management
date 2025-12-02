using Employee_Management.Application;
using Employee_Management.Infrastructure;

namespace Employee_Management_WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.ApplicationDI().InfrastructureDI();
            return services;
        }
    }
}
