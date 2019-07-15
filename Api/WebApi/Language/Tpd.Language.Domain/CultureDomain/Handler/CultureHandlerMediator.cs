using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.CultureDomain.Model;
using Tpd.Language.Domain.CultureDomain.Request;
using Tpd.Language.Domain.HandlerBase;

namespace Tpd.Language.Domain.CultureDomain.Handler
{
    public class CultureHandlerMediator : DomainMediatorBase,
        IDomainMediator<CultureModel, CultureModel, CultureModel, CultureModel, GetCulturesQuery>
    {
        public CultureHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(CultureModel model)
        {
            return await Create<Culture, CultureModel>(model);
        }

        public async Task<IResultCore<int>> Update(CultureModel model)
        {
            return await Update<Culture, CultureModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<Culture>(id);
        }

        public async Task<IResultCore<CultureModel>> GetItem(Guid id)
        {
            return await GetItem<Culture, CultureModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<CultureModel>>> GetItems(GetCulturesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
