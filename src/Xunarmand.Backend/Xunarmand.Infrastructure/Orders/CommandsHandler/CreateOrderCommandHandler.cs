using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Xunarmand.Application.Orders.Commands;
using Xunarmand.Application.Orders.Models;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;
using Xunarmand.Persistence.DataContext;

namespace Xunarmand.Infrastructure.Orders.CommandsHandler;

public class CreateOrderCommandHandler(IOrderService service, IMapper mapper)
    : ICommandHandler<OrderCreateCommand, OrderDto>
{
    public async Task<OrderDto> Handle(OrderCreateCommand request, CancellationToken cancellationToken)
    {
        var result = mapper.Map<Order>(request.Order);
        var resultnew = await service.CreateAsync(result, cancellationToken: cancellationToken);
        return mapper.Map<OrderDto>(resultnew);
    }
}