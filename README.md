# Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material
A meterial theme for [ABP Framework](/abpframework/abp).


## Installation
- Install [Nuget Package](https://www.nuget.org/packages/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material) to your **Web** project.

```bash
dotnet add package Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material
```

- Replace Basic Theme with Material Theme.

```diff

[DependsOn(
        typeof(SandboxHttpApiModule),
        typeof(SandboxApplicationModule),
        typeof(SandboxMongoDbModule),
        typeof(AbpAutofacModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpSettingManagementWebModule),
        typeof(AbpAccountWebIdentityServerModule),
-       typeof(AbpAspNetCoreMvcUiBasicThemeModule),
+       typeof(AbpAspNetCoreMvcUiMaterialThemeModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpTenantManagementWebModule),
        typeof(AbpAspNetCoreSerilogModule),
        typeof(AbpSwashbuckleModule)
        )]
    public class SandboxWebModule : AbpModule
    {
        // ...
```

