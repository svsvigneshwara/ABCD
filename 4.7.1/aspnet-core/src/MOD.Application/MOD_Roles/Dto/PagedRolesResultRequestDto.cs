using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Roles.Dto
{
    [AutoMap(typeof(Roles))]
    public class PagedRolesResultRequestDto : EntityDto<long>
    {

    }
}
