using Sandbox.MongoDB;
using Xunit;

namespace Sandbox
{
    [CollectionDefinition(SandboxTestConsts.CollectionDefinitionName)]
    public class SandboxDomainCollection : SandboxMongoDbCollectionFixtureBase
    {

    }
}
