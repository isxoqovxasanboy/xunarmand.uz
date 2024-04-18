using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(order => order.Price).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(order => order.ProductAmount).HasColumnType("decimal(18,2)").IsRequired();

        builder
            .HasOne(order => order.Product)
            .WithMany(product => product.Orders)
            .HasForeignKey(order => order.ProductId);
    }
}