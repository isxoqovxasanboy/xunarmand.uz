using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xunarmand.Domain.Entities;

namespace Xunarmand.Persistence.EntityConfigurations;

public class BasketConfiguration:IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.Property(basket => basket.OperationTime).IsRequired();
    }
}