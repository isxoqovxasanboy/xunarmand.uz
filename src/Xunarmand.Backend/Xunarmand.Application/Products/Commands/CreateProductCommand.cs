using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Product.Commands;

public record CreateProductCommand:ICommand<ProductDto>
{
    public ProductCredential CreateProduct { get; set; }
}