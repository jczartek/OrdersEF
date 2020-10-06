using DataLayer.Configurations;
using DataLayer.Entities;
using System;
using Xunit;

namespace TestLayer
{
    public class ConfigFactoryTest
    {
        [Fact]
        public void CreateConfigClass()
        {
            var configProduct1 = ConfigFactory.ConfigFor<Product>();

            Assert.Equal("ProductConfig", configProduct1.GetType().Name);
        }
    }
}
