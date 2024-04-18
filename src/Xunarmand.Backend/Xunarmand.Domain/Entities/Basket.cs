using Xunarmand.Domain.Common.Entities;
using Xunarmand.Domain.Enums;

namespace Xunarmand.Domain.Entities;

/// <summary>
/// Represents a basket entity that stores information about a user's shopping basket.
/// Inherits from the AuditableEntity class to include audit-related properties like creation and modification timestamps.
/// </summary>
public class Basket : AuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the user associated with this basket.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the timestamp of the basket operation.
    /// </summary>
    public DateTimeOffset OperationTime { get; set; }

    /// <summary>
    /// Gets or sets the status of the basket, such as open, closed, etc.
    /// </summary>
    public ProductStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the user object associated with this basket.
    /// </summary>
    public User? User { get; set; }
}
