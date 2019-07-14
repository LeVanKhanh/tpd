﻿using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.HandlerBase;
using Tpd.Language.Domain.TranslationDomain.Model;
using Tpd.Language.Domain.TranslationDomain.Request;
using Tpd.Language.Domain.TranslationDomain.Result;

namespace Tpd.Language.Domain.TranslationDomain.Handler
{
    public class TranslationHandlerMediator : DomainMediatorBase,
        IDomainMediator<TranslationModel, TranslationModel, TranslationModel, ResoureEntryModel, GetTranslationsQuery>
    {
        public TranslationHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<int> Create(TranslationModel model)
        {
            return await Create<Translation, TranslationModel>(model);
        }

        public async Task<int> Update(TranslationModel model)
        {
            return await Update<Translation, TranslationModel>(model);
        }

        public async Task<int> Remove(Guid id)
        {
            return await Remove<Translation>(id);
        }

        public async Task<TranslationModel> GetItem(Guid id)
        {
            return await GetItem<Translation, TranslationModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<ResoureEntryModel>>> GetItems(GetTranslationsQuery query)
        {
            return await base.GetItems(query);
        }
    }
}