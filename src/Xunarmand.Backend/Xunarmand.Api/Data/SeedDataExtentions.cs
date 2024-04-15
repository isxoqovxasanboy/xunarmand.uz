using Microsoft.EntityFrameworkCore;
using Xunarmand.Domain.Entities;
using Xunarmand.Persistence.DataContext;

namespace Xunarmand.Api.Data;

public static class SeedDataExtensions
{
    /// <summary>
    /// Initializes the seed data asynchronously.
    /// </summary>
    public static async ValueTask InitializeSeedAsync(this IServiceProvider serviceProvider)
    {
        var appDbContext = serviceProvider.GetRequiredService<AppDbContext>();

        if (!await appDbContext.Users.AnyAsync())
             await appDbContext.SeedUsersAsync();
    }

    private static async ValueTask SeedUsersAsync(this AppDbContext dbContext)
        {
            var clients = new List<User>
            {
                new()
                {
                    Id = Guid.Parse("54e16318-d140-4453-80c9-1a117dbe75fd"),
                    FirstName = "John",
                    LastName = "Doe",
                    Birthday = "10.20.2002",
                    PhoneNumber = "123456789012",
                    Email = "example@gmail.com",
                    Password = "$2a$12$pHdneNbJGp4SnN1ovHrNqevf6I.k3Gy.7OMJoWWB0RByv0foi4fgy", // qwerty123
                },
                new()
                {
                    Id = Guid.Parse("5edbb0fe-7263-4f75-bad8-c9f3d422dd1d"),
                    FirstName = "Bob",
                    LastName = "Richard",
                    Birthday = "10.20.2002",
                    PhoneNumber = "123456789012",
                    Email = "tastBobRichard@gmail.com",
                    Password = "$2a$12$LxSqe5AE7AtglesHHK5NROFdJQdA1r1XKqhzg4q/tMTZjVEH0PNSK", //asdf1234
                },
                new()
                {
                    Id = Guid.Parse("6357D344-CB69-4FAA-81C5-AC0FC59AE0F9"),
                    FirstName = "Sarah",
                    LastName = "Funk",
                    Birthday = "10.20.2002",
                    PhoneNumber = "123456789012",
                    Email = "sarah.funk@gmail.com",
                    Password = "$2a$12$LxSqe5AE7AtglesHHK5NROFdJQdA1r1XKqhzg4q/tMTZjVEH0PNSK", //asdf1234
                }
            };

            await dbContext.Users.AddRangeAsync(clients);
            await dbContext.SaveChangesAsync();
        }
    
}