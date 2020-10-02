using DataLayer.Configurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationDbContex : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(ConfigFactory.Create<Category>());
            modelBuilder.ApplyConfiguration(ConfigFactory.Create<Product>());
            modelBuilder.ApplyConfiguration(ConfigFactory.Create<Supplier>());
        }
    }
}
