using AutoMapper;
using Xunarmand.Application.User.Models;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Infrastructure.User.QueryHandlers;

public class UserGetByIdQueryHandler(IUserService service,IMapper mapper):IQueryHandler<UserGetByIDQuery, UserDto>
{
    public async Task<UserDto> Handle(UserGetByIDQuery request, CancellationToken cancellationToken)
    {
        var founduser = await service.GetByIdAsync(
            request.Id,
            new QueryOptions()
            {
                TrackingMode = QueryTrackingMode.AsNoTracking
            },
            cancellationToken
        );
        return mapper.Map<UserDto>(founduser);
    }
}