using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.MOD_Domains.Dto;


namespace MOD.MOD_Domains
{
    public class DomainAppService : AsyncCrudAppService<Domain, DomainDto, long, PagedDomainResultRequestDto, CreateDomainDto, UpdateDomainDto>
    {
        public DomainAppService(IRepository<Domain, long> repository) : base(repository)
        {

        }
    }

}