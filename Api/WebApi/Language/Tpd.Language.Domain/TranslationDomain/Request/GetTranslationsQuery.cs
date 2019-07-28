using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Language.Domain.TranslationDomain.Result;

namespace Tpd.Language.Domain.TranslationDomain.Request
{
    public class GetTranslationsQuery: QueryListCore<ResoureEntryModel>
    {
        public string Application { get; set; }
        public string Module { get; set; }
        public string Culture { get; set; }
    }
}
