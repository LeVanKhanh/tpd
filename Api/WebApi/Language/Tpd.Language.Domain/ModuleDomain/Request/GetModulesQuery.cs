using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Language.Domain.ModuleDomain.Model;
using Tpd.Language.Domain.ModuleDomain.Result;

namespace Tpd.Language.Domain.ModuleDomain.Request
{
    public class GetModulesQuery : QueryListCore<GetModulesResult>
    {
        public string ApplicationName { get; set; }
        public string ModuleName { get; set; }
    }
}
