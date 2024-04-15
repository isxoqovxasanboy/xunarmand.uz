using Xunarmand.Application.User.Command;
using Xunarmand.Application.User.Queries;
using Xunarmand.Domain.Common.Commands;

namespace Xunarmand.Infrastructure.User.CommandHandlers;

public class UserDaleteByIdCommandHandler(IUserService service):ICommandHandler<UserDeleteByIdCommand, bool>
{
    public async Task<bool> Handle(UserDeleteByIdCommand request, CancellationToken cancellationToken)
    {
        await service.DeleteByIdAsync(request.UserId, cancellationToken: cancellationToken);
        return true;
    }
}