using Sandbox.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Sandbox
{
    [DependsOn(
        typeof(SandboxEntityFrameworkCoreTestModule)
        )]
    public class SandboxDomainTestModule : AbpModule
    {

    }
}