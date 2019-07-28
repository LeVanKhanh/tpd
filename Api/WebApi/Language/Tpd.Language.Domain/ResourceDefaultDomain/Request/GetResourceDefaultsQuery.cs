using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Language.Domain.ResourceDefaultDomain.Model;

namespace Tpd.Language.Domain.ResourceDefaultDomain.Request
{
    public class GetResourceDefaultsQuery : QueryListCore<ResourceDefaultModel>
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
