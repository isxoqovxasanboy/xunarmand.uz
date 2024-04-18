using AutoMapper;
using Xunarmand.Application.Product.Commands;
using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Products.CommandHandlers;

public class CreateProductCommandHandler(IProductService service, IMapper mapper):ICommandHandler<CreateProductCommand, ProductDto>
{
    public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request.CreateProduct);
        var newProduct = await service.CreateAsync(product, cancellationToken: cancellationToken);
        var result = mapper.Map<ProductDto>(newProduct);
        return  result;
        
    }
}