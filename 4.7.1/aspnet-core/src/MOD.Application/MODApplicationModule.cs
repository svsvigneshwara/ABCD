using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MOD.Authorization;

namespace MOD
{
    [DependsOn(
        typeof(MODCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MODApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MODAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MODApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
