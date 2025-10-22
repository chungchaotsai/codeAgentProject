namespace Nine1.NMQ.Dashboard.Core.Interfaces;

/// <summary>
/// Interface for dashboard service
/// </summary>
public interface IDashboardService : IService
{
    /// <summary>
    /// Gets the dashboard status
    /// </summary>
    /// <returns>Status message</returns>
    Task<string> GetStatusAsync();
}
