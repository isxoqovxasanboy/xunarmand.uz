using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Product.Commands;

public record UpdateProductCommand:ICommand<ProductDto>
{
    public ProductDto UpdateProduct { get; set; }
}