using Microsoft.Extensions.DependencyInjection;
using Portal.Services;

namespace Portal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddHttpClient<ITimeService, TimeService>();
            return services;
        }
    }
}
