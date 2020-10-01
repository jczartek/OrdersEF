using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.ToTable("Products", schema: "Production");

            entity.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);

            entity.HasOne(p => p.Supplier)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.SupplierId);

            entity.Property(p => p.UnitPrice)
                .HasColumnType("Money");

            entity.HasIndex(p => p.CategoryId)
                .HasName("idx_categoryid");

            entity.HasIndex(p => p.ProductName)
                .HasName("idx_productname");

            entity.HasIndex(p => p.SupplierId)
                .HasName("idx_supplierid");

            entity.HasCheckConstraint("CHK_Product_unitprice", "([unitprice] >= (0))");
        }
    }
}
