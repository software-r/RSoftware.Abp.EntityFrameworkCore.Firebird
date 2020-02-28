using FirebirdSql.EntityFrameworkCore.Firebird.Infrastructure;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;

namespace RSoftware.Abp.EntityFrameworkCore
{
    public static class AbpDbContextConfigurationContextFirebirdExtensions
    {
        public static DbContextOptionsBuilder UseFirebird(
            [NotNull] this AbpDbContextConfigurationContext context,
            [CanBeNull] Action<FbDbContextOptionsBuilder> fbOptionsAction = null)
        {
            if (context.ExistingConnection != null)
            {
                return context.DbContextOptions.UseFirebird(context.ExistingConnection, fbOptionsAction);
            }
            else
            {
                return context.DbContextOptions.UseFirebird(context.ConnectionString, fbOptionsAction);
            }
        }
    }
}
