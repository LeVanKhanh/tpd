using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.HandlerBase;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionCategoryHandler.Request;

namespace Tpd.Quiz.Handler.QuestionCategoryHandler.Handler
{
    public class QuestionCategoryHandlerMediator : HandlerMediatorBase,
         IHandlerMediator<QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, QuestionCategoryModel, GetQuestionCategoriesQuery>
    {
        public QuestionCategoryHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(QuestionCategoryModel model)
        {
            return await Create<QuestionCategory, QuestionCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Update(QuestionCategoryModel model)
        {
            return await Update<QuestionCategory, QuestionCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<QuestionCategory>(id);
        }

        public async Task<IResultCore<QuestionCategoryModel>> GetItem(Guid id)
        {
            return await GetItem<QuestionCategory, QuestionCategoryModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<QuestionCategoryModel>>> GetItems(GetQuestionCategoriesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
