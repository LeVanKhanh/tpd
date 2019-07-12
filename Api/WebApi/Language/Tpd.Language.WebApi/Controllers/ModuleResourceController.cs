using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.ModuleResourceDomain.Model;
using Tpd.Language.Domain.ModuleResourceDomain.Query;
using Tpd.Language.Domain.ModuleResourceDomain.Result;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleResourceController : CurdControllerCore<ModuleResourceModel, ModuleResourceModel, ModuleResourceModel,
        GetModuleResourcesResult, GetModuleResourcesQuery>
    {
        public ModuleResourceController(IDomainMediator<ModuleResourceModel, ModuleResourceModel, ModuleResourceModel,
        GetModuleResourcesResult, GetModuleResourcesQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
