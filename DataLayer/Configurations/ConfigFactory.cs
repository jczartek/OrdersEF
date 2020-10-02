using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Configurations
{
    public class ConfigFactory
    {
        public static IEntityTypeConfiguration<TEntity> ConfigFor<TEntity>()
            where TEntity : class, new()
        {
            var nameTypeEntity = typeof(TEntity).Name;
            var nameTypeContigClass = $"{nameTypeEntity}Config";
            var type = Type.GetType(nameTypeContigClass);

            if (type == null)
                throw new ArgumentException($"{nameTypeContigClass} doesn't exist");

            return (IEntityTypeConfiguration<TEntity>) type.Assembly.CreateInstance(nameTypeContigClass);
        }
    }
}
