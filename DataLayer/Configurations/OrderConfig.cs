using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.ToTable("Orders", schema: "Sales");

            entity.HasOne(p => p.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.CustomerId);

            entity.HasOne(p => p.Employee)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.EmployeeId);

            entity.HasOne(p => p.Shipper)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ShipperId);

            entity.HasIndex(p => p.CustomerId)
                .HasName("idx_customerid");

            entity.HasIndex(p => p.EmployeeId)
                .HasName("idx_employeeid");

            entity.HasIndex(p => p.OrderDate)
                .HasName("idx_orderdate");

            entity.HasIndex(p => p.ShippedDate)
                .HasName("idx_shippeddate");

            entity.HasIndex(p => p.ShipperId)
                .HasName("idx_shipperid");

            entity.HasIndex(p => p.ShipPostalCode)
                .HasName("idx_shippostalcode");
        }
    }
}
