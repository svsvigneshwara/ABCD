using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MOD.MultiTenancy.Dto;

namespace MOD.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

