using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Features.Dto
{
    [AutoMap(typeof(Features))]
    public class CreateFeaturesDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
