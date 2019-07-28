using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Language.Data;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Language.Domain.ModuleDomain.Request;
using Tpd.Language.Domain.ModuleDomain.Result;

namespace Tpd.Language.Domain.ModuleDomain.Handler
{
    public class GetModulesHandler : QueryListHandlerBase<GetModulesQuery, GetModulesResult>
    {
        public GetModulesHandler(DatabaseContext data, IValidationService validationService)
            : base(data, validationService)
        {

        }

        protected override async Task<IQueryable<GetModulesResult>> BuildQueryAsync(GetModulesQuery query, RequestContextCore context)
        {
            var moduleQuery = Data.Module.AsQueryable();
            if (!string.IsNullOrEmpty(query.ApplicationName))
            {
                moduleQuery = moduleQuery.Where(w => w.Application.ShortName.Contains(query.ApplicationName)
                || w.Application.FullName.Contains(query.ApplicationName));
            }
            if (!string.IsNullOrEmpty(query.ModuleName))
            {
                moduleQuery = moduleQuery.Where(w => w.Name.Contains(query.ModuleName));
            }

            return moduleQuery.Select(s => new GetModulesResult
            {
                ApplicationFullName = s.Application.FullName,
                ApplicationShortName = s.Application.ShortName,
                ApplicationId = s.ApplicationId,
                Id = s.Id,
                Name = s.Name
            });
        }
    }
}
