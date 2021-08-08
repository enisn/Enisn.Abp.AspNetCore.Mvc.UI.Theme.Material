using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Sandbox.Pages
{
    [Collection(SandboxTestConsts.CollectionDefinitionName)]
    public class Index_Tests : SandboxWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
