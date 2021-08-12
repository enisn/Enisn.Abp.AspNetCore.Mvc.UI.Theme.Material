﻿using Volo.Abp.GlobalFeatures;
using Volo.Abp.Threading;

namespace Sandbox
{
    public static class SandboxGlobalFeatureConfigurator
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =>
                {
                    cmsKit.EnableAll();
                    cmsKit.Menu.Disable();
                });

                /* You can configure (enable/disable) global features of the used modules here.
                 *
                 * YOU CAN SAFELY DELETE THIS CLASS AND REMOVE ITS USAGES IF YOU DON'T NEED TO IT!
                 *
                 * Please refer to the documentation to lear more about the Global Features System:
                 * https://docs.abp.io/en/abp/latest/Global-Features
                 */
            });
        }
    }
}
