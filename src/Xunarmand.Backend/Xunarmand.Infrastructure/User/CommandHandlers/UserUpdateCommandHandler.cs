using AutoMapper;
using Xunarmand.Application.User.Command;
using Xunarmand.Application.User.Models;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Infrastructure.User.CommandHandlers;

public class UserUpdateCommandHandler(IUserService service ,IMapper mapper):ICommandHandler<UserUpdateCommand,Domain.Entities.User>
{
    public async Task<Domain.Entities.User> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Domain.Entities.User>(request.UserDto);
        var updateuser =  await service.UpdateAsync(entity, cancellationToken:cancellationToken);
        
        return updateuser;

    }
}