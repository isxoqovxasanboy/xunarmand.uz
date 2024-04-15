using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Application.User.Command;

public record UserDeleteByIdCommand:ICommand<bool>
{
    public Guid UserId { get; set; }
}