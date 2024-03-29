﻿using Microsoft.AspNetCore.Mvc;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.WebApi.Controller;
using Tpd.Language.Domain.TranslationDomain.Model;
using Tpd.Language.Domain.TranslationDomain.Request;
using Tpd.Language.Domain.TranslationDomain.Result;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : CurdControllerCore<TranslationModel, TranslationModel, TranslationModel,
        ResoureEntryModel, GetTranslationsQuery>
    {
        public TranslationController(IHandlerMediator<TranslationModel, TranslationModel, TranslationModel,
        ResoureEntryModel, GetTranslationsQuery> domainMediator)
            : base(domainMediator)
        {

        }
    }
}
