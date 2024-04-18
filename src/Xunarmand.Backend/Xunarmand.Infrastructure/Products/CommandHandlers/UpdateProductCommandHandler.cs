using AutoMapper;
using Xunarmand.Application.Product.Commands;
using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Products.CommandHandlers;

public class UpdateProductCommandHandler(IProductService service, IMapper mapper):ICommandHandler<UpdateProductCommand,ProductDto>
{
    public async Task<ProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var updateProduct = mapper.Map<Product>(request.UpdateProduct);
        
        var product = await service.UpdateAsync(updateProduct, cancellationToken: cancellationToken);
        
        return mapper.Map<ProductDto>(product);
    }
}