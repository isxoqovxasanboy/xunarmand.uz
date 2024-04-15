using Xunarmand.Domain.Common.Entities;

namespace Xunarmand.Domain.Entities;

public class User:AuditableEntity
{
    public Guid Id { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }

    public string Email { get; set; } = default!;

    public string Password { get; set; } = default!;
    
    public string? PhoneNumber { get; set; }
    
    public string? Brithday{ get; set; }
}