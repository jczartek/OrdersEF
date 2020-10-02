using DataLayer.Configurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationDbContex : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Category>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Product>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Supplier>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Shipper>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Employee>());
        }
    }
}
