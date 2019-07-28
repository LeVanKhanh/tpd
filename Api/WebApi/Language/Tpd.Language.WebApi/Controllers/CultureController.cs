using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
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
        public CultureController(IHandlerMediator<CultureModel, CultureModel, CultureModel,
            CultureModel, GetCulturesQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
