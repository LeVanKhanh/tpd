using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.HandlerBase;
using Tpd.Quiz.Handler.QuestionHandler.Model;
using Tpd.Quiz.Handler.QuestionHandler.Request;

namespace Tpd.Quiz.Handler.QuestionHandler.Handler
{
    public class QuestionHandlerMediator : HandlerMediatorBase,
         IHandlerMediator<QuestionModel, QuestionModel, QuestionModel, QuestionModel, GetQuestionsQuery>
    {
        public QuestionHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(QuestionModel model)
        {
            return await Create<Question, QuestionModel>(model);
        }

        public async Task<IResultCore<int>> Update(QuestionModel model)
        {
            return await Update<Question, QuestionModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<Question>(id);
        }

        public async Task<IResultCore<QuestionModel>> GetItem(Guid id)
        {
            return await GetItem<Question, QuestionModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<QuestionModel>>> GetItems(GetQuestionsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}

