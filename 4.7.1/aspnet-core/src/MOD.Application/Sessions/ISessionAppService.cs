using System.Threading.Tasks;
using Abp.Application.Services;
using MOD.Sessions.Dto;

namespace MOD.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
