using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.ApplicationDomain.Model;
using Tpd.Language.Domain.ApplicationDomain.Request;
using Tpd.Language.Domain.HandlerBase;

namespace Tpd.Language.Domain.ApplicationDomain.Handler
{
    public class ApplicationHandlerMediator : DomainMediatorBase,
        IDomainMediator<ApplicationModel, ApplicationModel, ApplicationModel, ApplicationModel, GetApplicationsQuery>
    {
        public ApplicationHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<int> Create(ApplicationModel model)
        {
            return await Create<Application, ApplicationModel>(model);
        }

        public async Task<int> Update(ApplicationModel model)
        {
            return await Update<Application, ApplicationModel>(model);
        }

        public async Task<int> Remove(Guid id)
        {
            return await Remove<Application>(id);
        }

        public async Task<ApplicationModel> GetItem(Guid id)
        {
            return await GetItem<Application, ApplicationModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<ApplicationModel>>> GetItems(GetApplicationsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
