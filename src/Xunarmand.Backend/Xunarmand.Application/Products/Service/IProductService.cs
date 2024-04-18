
using System.Linq.Expressions;
using Xunarmand.Application.Product.Models;
using Xunarmand.Application.Users.Models;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;

public interface IProductService
{
       /// <summary>
    /// Retrieves a queryable collection of client entities based on the specified predicate and query options.
    /// </summary>
    /// <param name="predicate">A predicate to filter the clients (optional).</param>
    /// <param name="queryOptions">Options for customizing the query (optional).</param>
    /// <returns>A queryable collection of client entities.</returns>
    IQueryable<Product> Get(Expression<Func<Product, bool>>? predicate = default, QueryOptions queryOptions = default);

    /// <summary>
    /// Retrieves a queryable collection of client entities based on the specified client filter and query options.
    /// </summary>
    /// <param name="clientFilter">A filter to apply when retrieving clients.</param>
    /// <param name="queryOptions">Options for customizing the query (optional).</param>
    /// <returns>A queryable collection of client entities.</returns>
    IQueryable<Product> Get(ProductFilter clientFilter, QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a client entity by its unique identifier and query options.
    /// </summary>
    /// <param name="userId">The unique identifier of the client.</param>
    /// <param name="queryOptions">Options for customizing the query (optional).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the client entity, or null if not found.</returns>
    ValueTask<Product?> GetByIdAsync(Guid userId, QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new client entity with the specified options.
    /// </summary>
    /// <param name="product">The user entity to create.</param>
    /// <param name="commandOptions">Options for customizing the command (optional).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the created client entity.</returns>
    ValueTask<Product> CreateAsync(Product product, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates an existing client entity with the specified options.
    /// </summary>
    /// <param name="product">The user entity to update.</param>
    /// <param name="commandOptions">Options for customizing the command (optional).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the updated user entity.</returns>
    ValueTask<Product> UpdateAsync(Product product, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a client entity by its unique identifier with the specified options.
    /// </summary>
    /// <param name="productId">The unique identifier of the user to delete.</param>
    /// <param name="commandOptions">Options for customizing the command (optional).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the deleted client entity, or null if not found.</returns>
    ValueTask<Product?> DeleteByIdAsync(Guid productId, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);
}