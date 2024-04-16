using System.Linq.Expressions;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.Repositories.Interface;

 public interface IProductRepository
{
    /// <summary>
    /// Retrieves a queryable collection of client entities based on the specified predicate.
    /// </summary>
    /// <param name="predicate">A predicate to filter the clients (optional).</param>
    /// <param name="queryOptions">Indicates whether the entities should be queried without tracking changes (default is false).</param>
    /// <returns>A queryable collection of client entities.</returns>
    IQueryable<Product> Get(Expression<Func<Product, bool>>? predicate = default, QueryOptions queryOptions = default);

    /// <summary>
    /// Asynchronously retrieves a client entity by its unique identifier.
    /// </summary>
    /// <param name="clientId">The unique identifier of the client.</param>
    /// <param name="queryOptions">Indicates whether the entity should be queried without tracking changes (default is false).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the client entity, or null if not found.</returns>
    ValueTask<Product?> GetByIdAsync(Guid clientId, QueryOptions queryOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously creates a new client entity with the specified options.
    /// </summary>
    /// <param name="user">The client entity to create.</param>
    /// <param name="commandOptions">Options for customizing the command (optional).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the created client entity.</returns>
    ValueTask<Product> CreateAsync(Product product, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously updates an existing client entity.
    /// </summary>
    /// <param name="user">The client entity to update.</param>
    /// <param name="commandOptions">Indicates whether changes should be saved to the underlying data store (default is true).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the updated client entity.</returns>
    ValueTask<Product> UpdateAsync(Product product, CommandOptions commandOptions = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously deletes a client entity by its unique identifier.
    /// </summary>
    /// <param name="clientId">The unique identifier of the client to delete.</param>
    /// <param name="commandOptions">Indicates whether changes should be saved to the underlying data store (default is true).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation (optional).</param>
    /// <returns>A task representing the asynchronous operation, containing the deleted client entity, or null if not found.</returns>
    ValueTask<Product?> DeleteByIdAsync(Guid clientId, CommandOptions commandOptions,
        CancellationToken cancellationToken = default);
   
}