using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Language.Domain.ApplicationDomain.Model;

namespace Tpd.Language.Domain.ApplicationDomain.Request
{
    public class GetApplicationsQuery : QueryListCore<ApplicationModel>
    {
        public string ApplicationName { get; set; }
    }
}
