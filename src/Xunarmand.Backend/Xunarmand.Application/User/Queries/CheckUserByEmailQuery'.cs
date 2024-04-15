using Xunarmand.Application.User.Models;
using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Application.User.Queries;
/// <summary>
/// Represents user checking query that returns user's firstname if exists
/// </summary>
public class CheckUserByEmailQuery:IQuery<string>
{
    /// <summary>
    /// Gets user email address
    /// </summary>
    public string EmailAddress { get; set; } = default;
}