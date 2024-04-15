using Microsoft.EntityFrameworkCore;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Infrastructure.User.QueryHandlers;

public class UserCheckEmailQueryHandler(IUserService service):IQueryHandler<CheckUserByEmailQuery,string>
{
    public async Task<string> Handle(CheckUserByEmailQuery request, CancellationToken cancellationToken)
    {
        var clientFirstName = await service
                              .Get(
                                  client => client.Email == request.EmailAddress,
                                  new QueryOptions
                                  {
                                      TrackingMode = QueryTrackingMode.AsNoTracking
                                  }
                              )
                              .Select(client => client.FirstName)
                              .FirstOrDefaultAsync(cancellationToken: cancellationToken);

        return clientFirstName;
    }
}