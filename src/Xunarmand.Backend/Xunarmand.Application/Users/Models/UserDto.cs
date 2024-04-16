﻿namespace Xunarmand.Application.Users.Models;

/// <summary>
/// Data transfer object (DTO) representing a user.
/// </summary>
public class UserDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the listing.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string LastName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string EmailAddress { get; set; } = default!;

    /// <summary>
    /// Gets or sets the phone number of the user.
    /// </summary>
    public string? PhoneNumber { get; set; } = default!;

    /// <summary>
    /// Gets or sets the birthday of the user.
    /// </summary>
    public DateOnly Birthday { get; set; } = default!;
}