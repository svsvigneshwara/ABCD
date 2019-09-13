using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MOD.Configuration.Dto;

namespace MOD.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MODAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
