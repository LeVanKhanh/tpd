using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.CultureDomain.Model;
using Tpd.Language.Domain.CultureDomain.Request;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureController : CurdControllerCore<CultureModel, CultureModel, CultureModel,
        CultureModel, GetCulturesQuery>
    {
        public CultureController(IDomainMediator<CultureModel, CultureModel, CultureModel,
            CultureModel, GetCulturesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
