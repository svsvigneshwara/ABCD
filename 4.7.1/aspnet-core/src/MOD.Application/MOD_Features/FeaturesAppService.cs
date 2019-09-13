using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.MOD_Features.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Features
{
    public class FeaturesAppService : AsyncCrudAppService<Features, FeaturesDto, long, PagedFeaturesResultRequestDto, CreateFeaturesDto, UpdateFeaturesDto>
    {
        public FeaturesAppService(IRepository<Features, long> repository) : base(repository)
        {

        }
    }
}
