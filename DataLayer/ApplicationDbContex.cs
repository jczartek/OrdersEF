using DataLayer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationDbContex : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new SupplierConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
