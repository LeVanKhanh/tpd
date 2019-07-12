using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Language.Domain.ModuleResourceDomain.Result;

namespace Tpd.Language.Domain.ModuleResourceDomain.Query
{
    public class GetModuleResourcesQuery : QueryListCore<GetModuleResourcesResult>
    {
        public string ApplicationName { get; set; }
        public string ModuleName { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
        public string ResourceDescription { get; set; }
    }
}
