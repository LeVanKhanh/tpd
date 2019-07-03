using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Tpd.Core.WebApi.Controller
{
    public abstract class ControllerCore: ControllerBase
    {
        protected IMediator Mediator { get; set; }
        public ControllerCore(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
