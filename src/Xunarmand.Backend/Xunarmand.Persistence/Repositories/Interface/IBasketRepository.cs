using System.Linq.Expressions;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.Repositories.Interface;

public interface IBasketRepository
{
      /// <summary>
    /// Retrieves a collection of orders based on the provided predicate and query options.
    /// </summary>
    /// <param name="predicate">An optional expression to filter orders.</param>
    /// <param name="queryOptions">Options for query customization.</param>
    /// <returns>An IQueryable collection of orders.</returns>
    IQueryable<Basket> Get(Expression<Func<Basket, bool>>? predicate = default, QueryOptions queryOptions = default);

    /// <summary>
    /// Retrieves an order by its unique identifier asynchronously.
    /// </summary>
    /// <param name="basketId">The unique identifier of the order.</param>
    /// <param name="queryOptions">Options for query customization.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A task representing the asynchronous operation, containing the order if found; otherwise, null.</returns>
    ValueTask<Basket?> GetByIdAsync(Guid basketId, QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new order asynchronously.
    /// </summary>
    /// <param name="basket">The order to be created.</param>
    /// <param name="commandOptions">Options for command customization.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A task representing the asynchronous operation, containing the created order.</returns>
    ValueTask<Basket> CreateAsync(Basket basket, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing order asynchronously.
    /// </summary>
    /// <param name="basket">The order to be updated.</param>
    /// <param name="commandOptions">Options for command customization.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A task representing the asynchronous operation, containing the updated order.</returns>
    ValueTask<Basket> UpdateAsync(Basket basket, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes an order by its unique identifier asynchronously.
    /// </summary>
    /// <param name="basketId">The unique identifier of the order to delete.</param>
    /// <param name="commandOptions">Options for command customization.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>A task representing the asynchronous operation, indicating the result of the deletion.</returns>
    ValueTask<Basket?> DeleteByIdAsync(Guid basketId, CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
}