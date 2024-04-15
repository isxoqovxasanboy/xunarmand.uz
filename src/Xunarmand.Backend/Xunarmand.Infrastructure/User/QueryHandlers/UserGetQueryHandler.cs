using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Xunarmand.Application.User.Models;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Infrastructure.User.QueryHandlers;

public class UserGetQueryHandler(IUserService service, IMapper mapper):IQueryHandler<UserGetQuery,ICollection<Domain.Entities.User>>
{
    public async Task<ICollection<Domain.Entities.User>> Handle(UserGetQuery request, CancellationToken cancellationToken)
    {
        var mecheduser = await service
                               .Get(request.Filter,
                                   new QueryOptions() { TrackingMode = QueryTrackingMode.AsNoTracking })
                               .ToListAsync(cancellationToken);
        return mecheduser;
    }
}