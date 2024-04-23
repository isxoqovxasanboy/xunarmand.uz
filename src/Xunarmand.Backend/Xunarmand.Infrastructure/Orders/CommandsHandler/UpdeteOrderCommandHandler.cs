using AutoMapper;
using Xunarmand.Application.Orders.Commands;
using Xunarmand.Application.Orders.Models;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Orders.CommandsHandler;

public class UpdeteOrderCommandHandler(IOrderService service,IMapper mapper):ICommandHandler<OrderUpdateCommand,OrderDto>
{
    public Task<OrderDto> Handle(OrderUpdateCommand request, CancellationToken cancellationToken)
    {
        var neworder = mapper.Map<Order>(request.Order);
        var result = service.UpdateAsync(neworder,cancellationToken: cancellationToken);
        return Task.FromResult(mapper.Map<OrderDto>(result));
    }
}