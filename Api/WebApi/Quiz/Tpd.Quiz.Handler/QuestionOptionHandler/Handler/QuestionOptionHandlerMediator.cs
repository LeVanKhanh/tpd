using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.HandlerBase;
using Tpd.Quiz.Handler.QuestionOptionHandler.Model;
using Tpd.Quiz.Handler.QuestionOptionHandler.Request;

namespace Tpd.Quiz.Handler.QuestionOptionHandler.Handler
{
    public class QuestionOptionHandlerMediator : HandlerMediatorBase,
         IHandlerMediator<QuestionOptionModel, QuestionOptionModel, QuestionOptionModel, QuestionOptionListItemModel, GetQuestionOptionsQuery>
    {
        public QuestionOptionHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(QuestionOptionModel model)
        {
            return await Create<QuestionOption, QuestionOptionModel>(model);
        }

        public async Task<IResultCore<int>> Update(QuestionOptionModel model)
        {
            return await Update<QuestionOption, QuestionOptionModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<QuestionOption>(id);
        }

        public async Task<IResultCore<QuestionOptionModel>> GetItem(Guid id)
        {
            return await GetItem<QuestionOption, QuestionOptionModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<QuestionOptionListItemModel>>> GetItems(GetQuestionOptionsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
