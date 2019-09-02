using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Quiz.Data.Entities;
using Tpd.Quiz.Handler.HandlerBase;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Model;
using Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Request;

namespace Tpd.Quiz.Handler.QuestionQuestionCategoryHandler.Handler
{
    public class QuestionQuestionCategoryHandlerMediator : HandlerMediatorBase,
         IHandlerMediator<QuestionQuestionCategoryModel, QuestionQuestionCategoryModel, 
         QuestionQuestionCategoryModel, QuestionQuestionCategoryListItemModel, GetQuestionsQuestionCategoriesQuery>
    {
        public QuestionQuestionCategoryHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(QuestionQuestionCategoryModel model)
        {
            return await Create<QuestionQuestionCategory, QuestionQuestionCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Update(QuestionQuestionCategoryModel model)
        {
            return await Update<QuestionQuestionCategory, QuestionQuestionCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<QuestionQuestionCategory>(id);
        }

        public async Task<IResultCore<QuestionQuestionCategoryModel>> GetItem(Guid id)
        {
            return await GetItem<QuestionQuestionCategory, QuestionQuestionCategoryModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<QuestionQuestionCategoryListItemModel>>> GetItems(GetQuestionsQuestionCategoriesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
