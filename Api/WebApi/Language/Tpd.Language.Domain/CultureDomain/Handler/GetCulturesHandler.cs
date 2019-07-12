using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Language.Data;
using Tpd.Language.Domain.CultureDomain.Model;
using Tpd.Language.Domain.CultureDomain.Request;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;

namespace Tpd.Language.Domain.CultureDomain.Handler
{
    public class GetCulturesHandler : QueryListHandlerBase<GetCulturesQuery, CultureModel>
    {
        private readonly IMapper _mapper;
        public GetCulturesHandler(DatabaseContext data, IMapper mapper) : base(data)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<CultureModel>> BuildQueryAsync(GetCulturesQuery query, RequestContextCore context)
        {
            var cultureQuery = Data.Culture.AsQueryable();
            if (!string.IsNullOrEmpty(query.Code))
            {
                cultureQuery = cultureQuery.Where(w => w.Code.Contains(query.Code));
            }
            if (!string.IsNullOrEmpty(query.Description))
            {
                cultureQuery = cultureQuery.Where(w => w.Description.Contains(query.Description));
            }

            return cultureQuery.ProjectTo<CultureModel>(_mapper.ConfigurationProvider);
        }
    }
}
