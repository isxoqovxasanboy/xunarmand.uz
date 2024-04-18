using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Application.Products.Queries;

public class ProductGetByIdQuery:IQuery<ProductDto>
{
    public Guid ProductId { get; set; }
}