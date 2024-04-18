using AutoMapper;
using Xunarmand.Application.Product.Commands;
using Xunarmand.Application.Product.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Products.CommandHandlers;

public class DeleteProductByIdCommandHandler(IProductService service,IMapper mapper):ICommandHandler<DeleteProductByIdCommand,bool>
{
    public async Task<bool> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
    {
          await service.DeleteByIdAsync(request.ProductId, cancellationToken: cancellationToken);
          
          return true;
    }
}