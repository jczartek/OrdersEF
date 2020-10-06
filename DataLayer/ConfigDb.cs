using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataLayer
{
    public sealed class ConfigDb
    {
        private static IConfigurationRoot _configuration;
        private static ConfigDb _instance = null;
        private static readonly object _instanceLock = new object();
        private ConfigDb()
        {
            var builder =
                new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
         
        }

        public static ConfigDb Instance
        {
            get
            {
                lock(_instanceLock)
                {
                    return _instance ??= new ConfigDb();
                }
            }
        }

        public IConfigurationRoot ConfigurationRoot
        {
            get
            {
                return _configuration ?? Instance.ConfigurationRoot;
            }
        }
    }
}
