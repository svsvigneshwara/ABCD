using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Domains.Dto
{
    [AutoMap(typeof(Domain))]
    public class DomainDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
