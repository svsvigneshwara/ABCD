using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Roles.Dto
{
    [AutoMap(typeof(Roles))]
    public class RolesDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Permissions { get; set; }
        public long FeaturesId { get; set; }
    }
}
