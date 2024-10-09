using Xunarmand.Application.Orders.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Application.Orders.Service;

public interface IOrderService
{
    Task<List<Order>> GetOrders(CancellationToken cancellationToken = default);

    ValueTask<Order> CreateAsync(Order order,
                                 CommandOptions commandOptions = default,
                                 CancellationToken cancellationToken = default);

    ValueTask DeleteAsync(Guid orderId,
                          CommandOptions commandOptions = default,
                          CancellationToken cancellationToken = default);

    ValueTask UpdateAsync(
        Order order,
        CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}