using DataLayer.Configurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationDbContex : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Category>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Product>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Supplier>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Shipper>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Employee>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Customer>());
            modelBuilder.ApplyConfiguration(ConfigFactory.ConfigFor<Order>());
        }
    }
}
