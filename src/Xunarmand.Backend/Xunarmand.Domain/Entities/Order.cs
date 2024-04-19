using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Xunarmand.Domain.Common.Entities;
using Xunarmand.Domain.Enums;

namespace Xunarmand.Domain.Entities;

public class Order : AuditableEntity
{
    // The total price of the order
    public decimal Price { get; set; }

    // The quantity of products in the order
    public int ProductAmount { get; set; }
    [NotMapped]
    // The ID of the user who placed the order
    public Guid UserId { get; set; }
    [NotMapped]
    // Navigation property representing the user who placed the order
    public User? User { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    // The date and time when the order was placed
    public DateTimeOffset OrderDate { get; set; }
}