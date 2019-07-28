using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Language.Domain.CultureDomain.Model;

namespace Tpd.Language.Domain.CultureDomain.Request
{
    public class GetCulturesQuery: QueryListCore<CultureModel>
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
