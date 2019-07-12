using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Language.Data;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Language.Domain.ModuleResourceDomain.Query;
using Tpd.Language.Domain.ModuleResourceDomain.Result;

namespace Tpd.Language.Domain.ModuleResourceDomain.Handler
{
    public class GetModuleResourcesHandler : QueryListHandlerBase<GetModuleResourcesQuery, GetModuleResourcesResult>
    {
        public GetModuleResourcesHandler(DatabaseContext data) : base(data)
        {

        }

        protected override async Task<IQueryable<GetModuleResourcesResult>> BuildQueryAsync(GetModuleResourcesQuery query, RequestContextCore context)
        {
            var moduleResourceQuery = Data.ModuleResource.AsQueryable();
            if (!string.IsNullOrEmpty(query.ApplicationName))
            {
                moduleResourceQuery = moduleResourceQuery.Where(w => w.Module.Application.FullName.Contains(query.ApplicationName)
                || w.Module.Application.ShortName.Contains(query.ApplicationName));
            }
            if (!string.IsNullOrEmpty(query.ModuleName))
            {
                moduleResourceQuery = moduleResourceQuery.Where(w => w.Module.Name.Contains(query.ModuleName));
            }
            if (!string.IsNullOrEmpty(query.ResourceKey))
            {
                moduleResourceQuery = moduleResourceQuery.Where(w => w.Baseline.Name.Contains(query.ResourceKey));
            }
            if (!string.IsNullOrEmpty(query.ResourceValue))
            {
                moduleResourceQuery = moduleResourceQuery.Where(w => w.Baseline.Value.Contains(query.ResourceValue));
            }
            if (!string.IsNullOrEmpty(query.ResourceDescription))
            {
                moduleResourceQuery = moduleResourceQuery.Where(w => w.Baseline.Description.Contains(query.ResourceDescription));
            }

            return moduleResourceQuery.Select(s => new GetModuleResourcesResult
            {
                Id = s.Id,
                ApplicationId = s.Module.ApplicationId,
                ModuleId = s.ModuleId,
                ResourceDefaultId = s.ResourceDefaultId,
                ApplicationName = s.Module.Application.FullName,
                ModuleName = s.Module.Name,
                ResourceKey = s.Baseline.Name,
                ResourceValue = s.Baseline.Value,
                ResourceDescription = s.Baseline.Description
            });
        }
    }
}
