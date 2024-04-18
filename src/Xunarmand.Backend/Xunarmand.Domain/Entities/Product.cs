using System.ComponentModel.DataAnnotations.Schema;
using Xunarmand.Domain.Common.Entities;

namespace Xunarmand.Domain.Entities;

/// <summary>
/// Represents a product entity in the system, inheriting auditable properties from the AuditableEntity base class.
/// </summary>
public class Product : AuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    public string ProductName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the type of the product.
    /// </summary>
    public string Type { get; set; } = default!;

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    public string? Description { get;  set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    public decimal Price { get;  set; } = default!;

    /// <summary>
    /// Gets or sets the URL of the product image.
    /// </summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// Gets or sets the collection of orders associated with the product.
    /// </summary>
    public ICollection<Order> Orders { get; set; }
}