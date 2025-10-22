namespace Nine1.NMQ.Dashboard.Core.Models;

/// <summary>
/// Base model for all entities
/// </summary>
public abstract class BaseModel
{
    /// <summary>
    /// Gets or sets the unique identifier
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the creation date
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
