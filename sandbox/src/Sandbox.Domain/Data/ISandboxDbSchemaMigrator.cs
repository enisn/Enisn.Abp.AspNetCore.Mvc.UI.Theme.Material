using System.Threading.Tasks;

namespace Sandbox.Data
{
    public interface ISandboxDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
