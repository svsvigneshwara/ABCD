using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.MOD_Roles.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Roles
{
    public class RolesAppService : AsyncCrudAppService<Roles, RolesDto, long, PagedRolesResultRequestDto, CreateRolesDto, UpdateRolesDto>
    {
        public RolesAppService(IRepository<Roles, long> repository) : base(repository)
        {

        }

    }
}
