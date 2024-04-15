using Xunarmand.Application.User.Models;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Application.User.Queries;
/// <summary>
/// Represents a command to retrieve a client by their unique identifier.
/// </summary>
public class UserGetByIDQuery:IQuery<UserDto>
{
    public Guid Id { get; set; }
}