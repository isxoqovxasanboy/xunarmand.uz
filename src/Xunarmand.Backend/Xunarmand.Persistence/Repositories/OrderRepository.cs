using System.Linq.Expressions;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;
using Xunarmand.Persistence.DataContext;
using Xunarmand.Persistence.Repositories.Interface;

namespace Xunarmand.Persistence.Repositories;

public class OrderRepository(AppDbContext dbContext)
    : EntityRepositoryBase<Order, AppDbContext>(dbContext), IOrderRepository
{
    public new IQueryable<Order> Get(Expression<Func<Order, bool>>? predicate = default,
        QueryOptions queryOptions = default)
        => base.Get(predicate, queryOptions);


    public new ValueTask<Order?> GetByIdAsync(Guid orderId, QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default)
        => base.GetByIdAsync(orderId, queryOptions, cancellationToken);


    public new ValueTask<Order> CreateAsync(Order order, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default)
    {
        return base.CreateAsync(order, commandOptions, cancellationToken);
    }

    public new ValueTask<Order> UpdateAsync(Order order, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default)
    {
        return base.UpdateAsync(order, commandOptions, cancellationToken);
    }

    public new ValueTask<Order?> DeleteByIdAsync(Guid orderId, CommandOptions commandOptions,
        CancellationToken cancellationToken = default)
        => base.DeleteByIdAsync(orderId, commandOptions, cancellationToken);
}