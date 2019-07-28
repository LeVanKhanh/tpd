using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.ResourceDefaultDomain.Model;
using Tpd.Language.Domain.ResourceDefaultDomain.Request;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceDefaultController : CurdControllerCore<ResourceDefaultModel, ResourceDefaultModel, ResourceDefaultModel,
        ResourceDefaultModel, GetResourceDefaultsQuery>
    {
        public ResourceDefaultController(IHandlerMediator<ResourceDefaultModel, ResourceDefaultModel, ResourceDefaultModel,
        ResourceDefaultModel, GetResourceDefaultsQuery> domainMediator)
            : base(domainMediator)
        {
        }
    }
}
