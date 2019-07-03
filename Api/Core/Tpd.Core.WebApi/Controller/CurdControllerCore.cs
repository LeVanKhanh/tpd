using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.WebApi.Controller
{
    public class CurdControllerCore<TModelCreate, TModelUpdate> : ControllerCore
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
    {
        protected IDomainMediator<TModelCreate, TModelUpdate> DomainMediator { get; set; }
        public CurdControllerCore(IDomainMediator<TModelCreate, TModelUpdate> domainMediator)
           : base(domainMediator.Mediator)
        {
            DomainMediator = domainMediator;
        }
    }
}