using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.MOD_Users.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Users
{
    public class UsersAppService : AsyncCrudAppService<Users, UsersDto, long, PagedUsersResultRequestDto, CreateUsersDto, UpdateUsersDto>
    {
        public UsersAppService (IRepository<Users,long> repository) : base(repository)
        {

        }
    }   
}
