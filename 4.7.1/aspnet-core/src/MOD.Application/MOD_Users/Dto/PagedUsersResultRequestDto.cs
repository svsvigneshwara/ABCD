using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Users.Dto
{
    [AutoMap(typeof(Users))]
    public class PagedUsersResultRequestDto : EntityDto<long>
    {
    }
}
