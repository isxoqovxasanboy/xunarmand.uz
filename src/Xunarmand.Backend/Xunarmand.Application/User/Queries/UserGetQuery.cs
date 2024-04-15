using Xunarmand.Application.User.Models;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Application.User.Queries;

public class UserGetQuery:IQuery<ICollection<Domain.Entities.User>>
{
    public UserFilter Filter { get; set; }
}