using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Sandbox.Data
{
    /* This is used if database provider does't define
     * ISandboxDbSchemaMigrator implementation.
     */
    public class NullSandboxDbSchemaMigrator : ISandboxDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}