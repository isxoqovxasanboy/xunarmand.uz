using System.Windows.Input;
using Xunarmand.Application.Users.Models;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.Users.Commands;

public record UserCreateCommand:ICommand<UserDto>
{
    public UserDto? User { get; set; }
}