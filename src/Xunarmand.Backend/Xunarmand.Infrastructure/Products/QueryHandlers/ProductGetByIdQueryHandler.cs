using AutoMapper;
using Xunarmand.Application.Product.Models;
using Xunarmand.Application.Products.Queries;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Infrastructure.Products.QueryHandlers;

public class ProductGetByIdQueryHandler(IProductService service,IMapper mapper) :IQueryHandler<ProductGetByIdQuery,ProductDto>
{
    public async Task<ProductDto> Handle(ProductGetByIdQuery request, CancellationToken cancellationToken)
    {
        var findProduct = await service.GetByIdAsync(request.ProductId, cancellationToken: cancellationToken);
        
        return mapper.Map<ProductDto>(findProduct);
    }
}