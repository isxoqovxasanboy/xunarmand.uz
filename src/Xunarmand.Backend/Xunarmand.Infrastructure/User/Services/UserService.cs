using System.Linq.Expressions;
using FluentValidation;
using Xunarmand.Application.User.Models;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Common.Queries;
using Xunarmand.Domain.Enums;
using Xunarmand.Infrastructure.User.Validators;
using Xunarmand.Persistence.Extensions;
using Xunarmand.Persistence.Repositories.Interface;

namespace Xunarmand.Infrastructure.User.Services;

public class UserService(IUserRepository userRepository,IValidator<Domain.Entities.User> validator):IUserService
{
    public IQueryable<Domain.Entities.User> Get(Expression<Func<Domain.Entities.User, bool>>? predicate = default, QueryOptions queryOptions = default)
         => userRepository.Get(predicate, queryOptions);

    public IQueryable<Domain.Entities.User> Get(UserFilter clientFilter, QueryOptions queryOptions = default)
        => userRepository.Get(queryOptions: queryOptions).ApplyPagination(clientFilter);
        
    public ValueTask<Domain.Entities.User?> GetByIdAsync(Guid clientId, QueryOptions queryOptions = default,
                                                         CancellationToken cancellationToken = default)
        => userRepository.GetByIdAsync(clientId, queryOptions, cancellationToken);

    public ValueTask<Domain.Entities.User> CreateAsync(Domain.Entities.User client,
                                                       CommandOptions commandOptions = default,
                                                       CancellationToken cancellationToken = default)
    {
        var validationResult = validator
            .Validate(client,
                options => 
                    options.IncludeRuleSets(EntityEvent.OnCreate.ToString()));

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        
        return userRepository.CreateAsync(client, new CommandOptions() { SkipSaveChanges = false }, cancellationToken);
    }
        

    public async ValueTask<Domain.Entities.User?> UpdateAsync(Domain.Entities.User client, CommandOptions commandOptions = default,
                                                        CancellationToken cancellationToken = default)
    {
        var foundClient = await GetByIdAsync(client.Id, cancellationToken: cancellationToken) ?? throw new InvalidOperationException();

        foundClient.FirstName = client.FirstName;
        foundClient.LastName = client.LastName;
        foundClient.Email = client.Email;

        return await userRepository.UpdateAsync(foundClient, commandOptions, cancellationToken);
    }

    public ValueTask<Domain.Entities.User?> DeleteByIdAsync(Guid clientId, CommandOptions commandOptions = default,
                                                            CancellationToken cancellationToken = default)
        => userRepository.DeleteByIdAsync(clientId, commandOptions, cancellationToken);
}