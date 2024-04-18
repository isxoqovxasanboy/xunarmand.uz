namespace Xunarmand.Application.Products.Models;

public class ProductCredential
{
    public string? ProductName { get; set; }

    /// <summary>
    /// Gets or sets the type of the product.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// Gets or sets the URL of the product image.
    /// </summary>
    public string? ImageUrl { get; set; }
}