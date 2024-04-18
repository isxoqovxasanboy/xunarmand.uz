using System.Linq.Expressions;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;
using Xunarmand.Persistence.DataContext;
using Xunarmand.Persistence.Repositories.Interface;

namespace Xunarmand.Persistence.Repositories;

public class BasketRepository(AppDbContext appDbContext)
    : EntityRepositoryBase<Basket, AppDbContext>(appDbContext), IBasketRepository
{
    public IQueryable<Basket> Get(Expression<Func<Basket, bool>>? predicate = default,
                                  QueryOptions queryOptions = default)
        => base.Get(predicate, queryOptions);

    public ValueTask<Basket?> GetByIdAsync(Guid basketId, QueryOptions queryOptions = default,
                                           CancellationToken cancellationToken = default)
        => base.GetByIdAsync(basketId, queryOptions, cancellationToken);

    public ValueTask<Basket> CreateAsync(Basket basket, CommandOptions commandOptions = default,
                                         CancellationToken cancellationToken = default)
        => base.CreateAsync(basket, commandOptions, cancellationToken);

    public ValueTask<Basket> UpdateAsync(Basket basket, CommandOptions commandOptions = default,
                                         CancellationToken cancellationToken = default)
        => base.UpdateAsync(basket, commandOptions, cancellationToken);

    public ValueTask<Basket?> DeleteByIdAsync(Guid basketId, CommandOptions commandOptions,
                                              CancellationToken cancellationToken = default)
        => base.DeleteByIdAsync(basketId, commandOptions, cancellationToken);
}