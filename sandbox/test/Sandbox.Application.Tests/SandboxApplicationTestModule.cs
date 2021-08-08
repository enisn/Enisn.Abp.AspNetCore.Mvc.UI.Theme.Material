using Volo.Abp.Modularity;

namespace Sandbox
{
    [DependsOn(
        typeof(SandboxApplicationModule),
        typeof(SandboxDomainTestModule)
        )]
    public class SandboxApplicationTestModule : AbpModule
    {

    }
}