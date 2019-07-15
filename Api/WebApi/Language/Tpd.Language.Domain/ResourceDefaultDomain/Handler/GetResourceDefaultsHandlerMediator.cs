using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.HandlerBase;
using Tpd.Language.Domain.ResourceDefaultDomain.Model;
using Tpd.Language.Domain.ResourceDefaultDomain.Request;

namespace Tpd.Language.Domain.ResourceDefaultDomain.Handler
{
    public class GetResourceDefaultsHandlerMediator : DomainMediatorBase,
        IDomainMediator<ResourceDefaultModel, ResourceDefaultModel, ResourceDefaultModel, ResourceDefaultModel, GetResourceDefaultsQuery>
    {
        public GetResourceDefaultsHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
           : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(ResourceDefaultModel model)
        {
            return await Create<ResourceDefault, ResourceDefaultModel>(model);
        }

        public async Task<IResultCore<int>> Update(ResourceDefaultModel model)
        {
            return await Update<ResourceDefault, ResourceDefaultModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<ResourceDefault>(id);
        }

        public async Task<IResultCore<ResourceDefaultModel>> GetItem(Guid id)
        {
            return await GetItem<ResourceDefault, ResourceDefaultModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<ResourceDefaultModel>>> GetItems(GetResourceDefaultsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
