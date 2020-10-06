using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataLayer.Configurations
{
    public class ConfigFactory
    {
        public static IEntityTypeConfiguration<TEntity> ConfigFor<TEntity>()
            where TEntity : class, new()
        {
            var nameTypeEntity = typeof(TEntity).Name;
            var nameTypeContigClass = $"DataLayer.Configurations.{nameTypeEntity}Config";

            if (!TryFindType(nameTypeContigClass, out Type type))
                throw new ArgumentException($"{nameTypeContigClass} doesn't exist");

            return (IEntityTypeConfiguration<TEntity>) type.Assembly.CreateInstance(nameTypeContigClass);
        }

        private static readonly Dictionary<string, Type> typeCache = new Dictionary<string, Type>();
        public static bool TryFindType(string typeName, out Type t)
        {
            lock (typeCache)
            {
                if (!typeCache.TryGetValue(typeName, out t))
                {
                    foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                    {
                        t = a.GetType(typeName);
                        if (t != null)
                            break;
                    }
                    typeCache[typeName] = t;
                }
            }
            return t != null;
        }
    }
}
