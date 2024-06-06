using System.ComponentModel.DataAnnotations.Schema;
using Xunarmand.Domain.Common.Entities;

namespace Xunarmand.Domain.Entities;

/// <summary>
/// Represents a user entity in the system, inheriting auditable properties from the AuditableEntity base class.
/// </summary>
public class User : AuditableEntity
{
    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string EmailAddress { get; set; } = default!;

    /// <summary>
    /// Gets or sets the password of the user.
    /// </summary>
    public string PasswordHash { get; set; } = default!;

    /// <summary>
    /// Gets or sets the phone number of the user.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the birthday of the user.
    /// </summary>
    public DateOnly Birthday { get; set; }

    /// <summary>
    /// Collection of orders placed by the user.
    /// </summary>
    public List<Order> Orders { get; set; } = new List<Order>();
}