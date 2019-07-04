using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.WebApi.Controller
{
    public class CurdControllerCore<TModelCreate, TModelUpdate, TResponse> : ControllerCore
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
    {
        protected IDomainMediator<TModelCreate, TModelUpdate, TResponse> DomainMediator { get; set; }
        public CurdControllerCore(IDomainMediator<TModelCreate, TModelUpdate, TResponse> domainMediator)
           : base(domainMediator.Mediator)
        {
            DomainMediator = domainMediator;
        }
    }
}