using Microsoft.Extensions.DependencyInjection;
using Nine1.NMQ.Dashboard.Core.Interfaces;
using Nine1.NMQ.Dashboard.Infrastructure.Services;

namespace Nine1.NMQ.Dashboard.Infrastructure.DependencyInjection;

/// <summary>
/// Extension methods for configuring infrastructure services
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds infrastructure services to the service collection
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>The service collection for chaining</returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Register services
        services.AddScoped<IDashboardService, DashboardService>();

        return services;
    }
}
