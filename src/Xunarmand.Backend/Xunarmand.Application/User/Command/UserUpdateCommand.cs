using Xunarmand.Application.User.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.User.Command;

public record UserUpdateCommand:ICommand<Domain.Entities.User>
{
    public UserDto UserDto { get; set; }
}