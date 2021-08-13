using Sandbox.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Sandbox.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SandboxEntityFrameworkCoreModule),
        typeof(SandboxApplicationContractsModule)
        )]
    public class SandboxDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
