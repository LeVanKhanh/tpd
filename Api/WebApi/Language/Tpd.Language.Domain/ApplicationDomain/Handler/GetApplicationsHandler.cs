using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Language.Data;
using Tpd.Language.Domain.ApplicationDomain.Model;
using Tpd.Language.Domain.ApplicationDomain.Request;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;

namespace Tpd.Language.Domain.ApplicationDomain.Handler
{
    public class GetApplicationsHandler : QueryListHandlerBase<GetApplicationsQuery, ApplicationModel>
    {
        private readonly IMapper _mapper;
        public GetApplicationsHandler(DatabaseContext data, IMapper mapper) : base(data)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<ApplicationModel>> BuildQueryAsync(GetApplicationsQuery query, RequestContextCore context)
        {
            var applicationQuery = Data.Application.AsQueryable();
            if (!string.IsNullOrEmpty(query.ApplicationName))
            {
                applicationQuery.Where(w => w.ShortName.Contains(query.ApplicationName) || w.FullName.Contains(query.ApplicationName));
            }

            return applicationQuery.ProjectTo<ApplicationModel>(_mapper.ConfigurationProvider);
        }
    }
}
