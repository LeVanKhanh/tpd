using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.ApplicationDomain.Model;
using Tpd.Language.Domain.ApplicationDomain.Request;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : CurdControllerCore<ApplicationModel, ApplicationModel, ApplicationModel, GetApplicationsQuery>
    {
        public ApplicationController(IDomainMediator<ApplicationModel, ApplicationModel, ApplicationModel, GetApplicationsQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
