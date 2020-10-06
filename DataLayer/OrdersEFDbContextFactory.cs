using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class OrdersEFDbContextFactory : IDesignTimeDbContextFactory<OrdersEFDbContext>
    {
        public OrdersEFDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrdersEFDbContext>();
            
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(ConfigDb.Instance.ConfigurationRoot.GetConnectionString("DbOrders"));

            return new OrdersEFDbContext(optionsBuilder.Options);
        }
    }
}
