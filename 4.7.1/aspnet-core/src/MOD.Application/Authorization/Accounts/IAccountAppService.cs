using System.Threading.Tasks;
using Abp.Application.Services;
using MOD.Authorization.Accounts.Dto;

namespace MOD.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
