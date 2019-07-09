﻿using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Language.Domain.TranslationDomain.Model;

namespace Tpd.Language.Domain.TranslationDomain.Request
{
    public class GetTranslationsQuery: QueryListCore<ResoureEntryModel>
    {
        public string Application { get; set; }
        public string Module { get; set; }
        public string Culture { get; set; }
    }
}
