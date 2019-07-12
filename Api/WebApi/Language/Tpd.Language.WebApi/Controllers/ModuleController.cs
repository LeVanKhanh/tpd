using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.ModuleDomain.Model;
using Tpd.Language.Domain.ModuleDomain.Request;
using Tpd.Language.Domain.ModuleDomain.Result;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : CurdControllerCore<ModuleModel, ModuleModel, ModuleModel,
        GetModulesResult, GetModulesQuery>
    {
        public ModuleController(IDomainMediator<ModuleModel, ModuleModel, ModuleModel,
            GetModulesResult, GetModulesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
