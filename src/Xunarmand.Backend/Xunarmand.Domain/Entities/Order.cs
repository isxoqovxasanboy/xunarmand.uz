using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Xunarmand.Domain.Common.Entities;
using Xunarmand.Domain.Enums;

namespace Xunarmand.Domain.Entities;

/// <summary>
/// Represents an order for a product.
/// </summary>
public class Order : AuditableEntity
{
    /// <summary>
    /// Gets or sets the price of the product in the order.
    /// </summary>
    public decimal Price { get; set; }
    
    /// <summary>
    /// Gets or sets the amount of the product in the order.
    /// </summary>
    public int ProductAmount { get; set; }

    /// <summary>
    /// Gets or sets the ID of the product associated with the order.
    /// </summary>
    public Guid ProductId { get; set; } = default!;
   
    /// <summary>
    /// Gets or sets the ID of the basket associated with the order.
    /// </summary>
    public Guid BasketId { get; set; }
    
    /// <summary>
    /// Gets or sets the product associated with the order.
    /// </summary>
    public Product Product { get; set; } 
    
    /// <summary>
    /// Gets or sets the Basket associated with the order.
    /// </summary>
    public Basket Basket { get; set; }
}
