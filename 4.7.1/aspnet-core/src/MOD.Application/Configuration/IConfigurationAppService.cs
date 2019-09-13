using System.Threading.Tasks;
using MOD.Configuration.Dto;

namespace MOD.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
