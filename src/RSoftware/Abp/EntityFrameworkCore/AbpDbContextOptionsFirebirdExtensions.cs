using FirebirdSql.EntityFrameworkCore.Firebird.Infrastructure;
using JetBrains.Annotations;
using System;
using Volo.Abp.EntityFrameworkCore;

namespace RSoftware.Abp.EntityFrameworkCore
{
    public static class AbpDbContextOptionsFirebirdExtensions
    {
        public static void UseFirebird(
            [NotNull] this AbpDbContextOptions options,
            [CanBeNull] Action<FbDbContextOptionsBuilder> fbOptionsAction = null)
        {
            options.Configure(context =>
            {
                context.UseFirebird(fbOptionsAction);
            });
        }

        public static void UseFirebird<TDbContext>(
            [NotNull] this AbpDbContextOptions options,
            [CanBeNull] Action<FbDbContextOptionsBuilder> fbOptionsAction = null)
            where TDbContext : AbpDbContext<TDbContext>
        {
            options.Configure<TDbContext>(context =>
            {
                context.UseFirebird(fbOptionsAction);
            });
        }
    }
}
