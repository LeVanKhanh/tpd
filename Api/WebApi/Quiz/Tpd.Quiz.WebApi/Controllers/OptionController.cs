using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Quiz.Handler.OptionHandler.Model;
using Tpd.Quiz.Handler.OptionHandler.Request;

namespace Tpd.Quiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : CurdControllerCore<OptionModel, OptionModel, OptionModel, OptionModel, GetOptionsQuery>
    {
        public OptionController(IHandlerMediator<OptionModel, OptionModel, OptionModel, OptionModel, GetOptionsQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
