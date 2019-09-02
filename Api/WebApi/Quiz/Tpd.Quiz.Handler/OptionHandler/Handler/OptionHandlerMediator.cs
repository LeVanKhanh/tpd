using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.HandlerBase;
using Tpd.Quiz.Handler.OptionHandler.Model;
using Tpd.Quiz.Handler.OptionHandler.Request;

namespace Tpd.Quiz.Handler.OptionHandler.Handler
{
    public class OptionHandlerMediator : HandlerMediatorBase,
         IHandlerMediator<OptionModel, OptionModel, OptionModel, OptionModel, GetOptionsQuery>
    {
        public OptionHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(OptionModel model)
        {
            return await Create<Option, OptionModel>(model);
        }

        public async Task<IResultCore<int>> Update(OptionModel model)
        {
            return await Update<Option, OptionModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<Option>(id);
        }

        public async Task<IResultCore<OptionModel>> GetItem(Guid id)
        {
            return await GetItem<Option, OptionModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<OptionModel>>> GetItems(GetOptionsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
