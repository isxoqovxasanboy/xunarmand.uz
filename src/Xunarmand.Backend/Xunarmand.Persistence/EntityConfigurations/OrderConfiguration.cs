using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(order => order.Price).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(order => order.ProductAmount).HasColumnType("decimal(18,2)").IsRequired();

        builder.HasOne(o => o.User)
               .WithMany(u => u.Orders)
               .HasForeignKey(o => o.UserId)
               .IsRequired();
        
        builder.HasMany(o => o.Products)
               .WithOne(p => p.Orders)
               .HasForeignKey(p => p.Id)
               .IsRequired();
    }
}