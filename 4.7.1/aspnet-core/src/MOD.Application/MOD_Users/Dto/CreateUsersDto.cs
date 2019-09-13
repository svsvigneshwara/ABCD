using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Users.Dto
{
    [AutoMap(typeof(Users))]
    public class CreateUsersDto : EntityDto<long>
    {
        public string Name { get; set; }
        public long RolesId { get; set; }
        public long UserCategoryId { get; set; }
    }
}
