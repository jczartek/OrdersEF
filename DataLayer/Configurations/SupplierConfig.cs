using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class SupplierConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> entity)
        {
            entity.ToTable("Suppliers", schema: "Production");

            entity.HasIndex(p => p.CompanyName)
                .HasName("idx_companyname");

            entity.HasIndex(p => p.PostalCode)
                .HasName("idx_postalcode");
        }
    }
}
