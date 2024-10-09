using Xunarmand.Application.Orders.Commands;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Infrastructure.Orders.CommandsHandler;

public class DeleteOrdetCommandHandler(IOrderService service):ICommandHandler<DeleteOrderCommand,bool>
{
    public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    { 
        var result  = service.DeleteAsync(request.OrderId, cancellationToken: cancellationToken);
        return  result == null ? false : true;
    }
}