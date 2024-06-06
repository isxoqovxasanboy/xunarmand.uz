using Xunarmand.Application.Orders.Queryies;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Orders.QueryHandler;

public class GetOrderQueryHandler(IOrderService service):IQueryHandler<OrderGetQueryCommand,ICollection<Order>>
{
    public async Task<ICollection<Order>> Handle(OrderGetQueryCommand request, CancellationToken cancellationToken)
    {
        return await service.GetOrders(cancellationToken: cancellationToken);
    }
}