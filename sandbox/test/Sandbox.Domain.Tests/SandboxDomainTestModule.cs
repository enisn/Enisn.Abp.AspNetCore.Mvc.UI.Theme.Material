using Sandbox.MongoDB;
using Volo.Abp.Modularity;

namespace Sandbox
{
    [DependsOn(
        typeof(SandboxMongoDbTestModule)
        )]
    public class SandboxDomainTestModule : AbpModule
    {

    }
}