using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.EntityConfigurations;

public class UserConfiguration:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(client => client.FirstName).HasMaxLength(64).IsRequired();
        builder.Property(client => client.LastName).HasMaxLength(64).IsRequired();
        builder.Property(client => client.Email).HasMaxLength(128).IsRequired();
        builder.Property(client => client.Password).HasMaxLength(128).IsRequired();
        
    }
}