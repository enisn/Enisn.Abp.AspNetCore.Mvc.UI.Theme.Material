using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Sandbox.MongoDB
{
    [DependsOn(
        typeof(SandboxTestBaseModule),
        typeof(SandboxMongoDbModule)
        )]
    public class SandboxMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = SandboxMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
