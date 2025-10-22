namespace Nine1.NMQ.Dashboard.Core.Models;

/// <summary>
/// Dashboard data model
/// </summary>
public class DashboardData : BaseModel
{
    /// <summary>
    /// Gets or sets the dashboard title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the dashboard description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets whether the dashboard is active
    /// </summary>
    public bool IsActive { get; set; } = true;
}
