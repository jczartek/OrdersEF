using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> entity)
        {
            entity.ToTable("OrderDetails", schema: "Sales");

            entity.HasKey(p => new { p.OrderId, p.ProductId });

            entity.Property(p => p.Qty)
                .HasColumnType("smallint");

            entity.Property(p => p.UnitPrice)
                .HasColumnType("money");

            entity.Property(p => p.Discount)
                .HasColumnType("numeric(4,3)");

            entity.HasOne(p => p.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId);

            entity.HasOne(p => p.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductId);

            entity.HasIndex(p => p.OrderId)
                .HasName("idx_orderid");

            entity.HasIndex(p => p.ProductId)
                .HasName("idx_productid");

            entity.HasCheckConstraint("CHK_discount", "([Discount] >= (0) AND [Discount] <= (1))");
            entity.HasCheckConstraint("CHK_qty", "([Qty]>(0))");
            entity.HasCheckConstraint("CHK_unitprice", "([UnitPrice]>=(0))");


        }
    }
}
