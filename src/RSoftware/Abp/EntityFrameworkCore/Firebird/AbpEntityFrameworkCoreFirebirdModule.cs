using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RSoftware.Abp.EntityFrameworkCore.Firebird
{
    [DependsOn(typeof(AbpEntityFrameworkCoreModule))]
    public class AbpEntityFrameworkCoreFirebirdModule : AbpModule
    {
    }
}