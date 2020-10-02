using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.ToTable("Employees", "HR");

            entity.HasOne(p => p.Manager)
                .WithMany(p => p.Subordinates)
                .HasForeignKey(p => p.MgrId);

            entity.HasCheckConstraint("CHK_birthdate", "([birthdate] <= CONVERT([date], sysdatetime()))");

            entity.HasIndex(p => p.LastName)
                .HasName("idx_lastname");

            entity.HasIndex(p => p.PostalCode)
                .HasName("idx_postalcode");
        }
    }
}
