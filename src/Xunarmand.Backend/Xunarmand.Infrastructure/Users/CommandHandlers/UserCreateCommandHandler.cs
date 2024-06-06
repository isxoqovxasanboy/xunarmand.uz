using AutoMapper;
using Xunarmand.Application.Users.Commands;
using Xunarmand.Application.Users.Models;
using Xunarmand.Application.Users.Services;
using Xunarmand.Domain.Common.Commands;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Infrastructure.Users.CommandHandlers;

public class UserCreateCommandHandler(IUserService service, IMapper mapper)
    : ICommandHandler<UserCreateCommand, UserDto>
{
    public async Task<UserDto> Handle(UserCreateCommand request, CancellationToken cancellationToken)
    {
        var user = mapper.Map<User>(request.User);
        
        var result = await service.CreateAsync(user, cancellationToken: cancellationToken);
        
        return mapper.Map<UserDto>(result);
    }
}