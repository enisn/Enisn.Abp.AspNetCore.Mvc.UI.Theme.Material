using System;
using System.Collections.Generic;
using System.Text;
using Sandbox.Localization;
using Volo.Abp.Application.Services;

namespace Sandbox
{
    /* Inherit your application services from this class.
     */
    public abstract class SandboxAppService : ApplicationService
    {
        protected SandboxAppService()
        {
            LocalizationResource = typeof(SandboxResource);
        }
    }
}
