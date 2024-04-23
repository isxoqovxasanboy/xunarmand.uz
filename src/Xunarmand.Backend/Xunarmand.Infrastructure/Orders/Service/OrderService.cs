using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Xunarmand.Application.Orders.Models;
using Xunarmand.Application.Orders.Service;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;
using Xunarmand.Persistence.DataContext;
using Xunarmand.Persistence.Repositories.Interface;

namespace Xunarmand.Infrastructure.Orders.Service;

public class OrderService(IOrderRepository repository, AppDbContext appDbContext, IMapper mapper) : IOrderService
{
    public async Task<List<Order>> GetOrders(CancellationToken cancellationToken = default)
    {
        return await appDbContext.Orders.ToListAsync();
    }

    public async ValueTask DeleteAsync(Guid orderId, CommandOptions commandOptions = default,
                                       CancellationToken cancellationToken = default)
        => repository.DeleteByIdAsync(orderId, commandOptions, cancellationToken);

    public async ValueTask UpdateAsync(Order order, CommandOptions commandOptions = default,
                                       CancellationToken cancellationToken = default)
    {
        var findorder = await repository.GetByIdAsync(order.Id) ??
                        throw new InvalidOperationException();

        // findorder.Products = order.Products;
        findorder.Price = order.Price;
        findorder.ProductAmount = order.ProductAmount;

        await repository.UpdateAsync(findorder, commandOptions, cancellationToken);
    }

    public ValueTask<Order> CreateAsync(Order order, CommandOptions commandOptions = default,
                                        CancellationToken cancellationToken = default)

    {
        return repository.CreateAsync(order, commandOptions, cancellationToken);
    }
}