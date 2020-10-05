using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.ToTable("Customers", schema: "Sales");

            entity.HasIndex(p => p.City)
                .HasName("idx_city");

            entity.HasIndex(p => p.CompanyName)
                .HasName("idx_companyname");

            entity.HasIndex(p => p.PostalCode)
                .HasName("idx_postalcode");

            entity.HasIndex(p => p.Region)
                .HasName("idx_region");
        }
    }
}
