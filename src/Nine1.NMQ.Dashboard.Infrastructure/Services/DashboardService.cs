using Nine1.NMQ.Dashboard.Core.Interfaces;

namespace Nine1.NMQ.Dashboard.Infrastructure.Services;

/// <summary>
/// Implementation of dashboard service
/// </summary>
public class DashboardService : IDashboardService
{
    /// <summary>
    /// Gets the dashboard status
    /// </summary>
    /// <returns>Status message</returns>
    public Task<string> GetStatusAsync()
    {
        return Task.FromResult("Dashboard is running");
    }
}
