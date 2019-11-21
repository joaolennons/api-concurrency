using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Portal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
            => services.AddSingleton<HttpClient>();
    }
}
