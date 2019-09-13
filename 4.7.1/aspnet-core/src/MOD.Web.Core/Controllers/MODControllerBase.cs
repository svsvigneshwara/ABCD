using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MOD.Controllers
{
    public abstract class MODControllerBase: AbpController
    {
        protected MODControllerBase()
        {
            LocalizationSourceName = MODConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
