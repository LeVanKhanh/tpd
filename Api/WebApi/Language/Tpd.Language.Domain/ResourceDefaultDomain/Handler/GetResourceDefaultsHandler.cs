using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Language.Data;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Language.Domain.ResourceDefaultDomain.Model;
using Tpd.Language.Domain.ResourceDefaultDomain.Request;

namespace Tpd.Language.Domain.ResourceDefaultDomain.Handler
{
    public class GetResourceDefaultsHandler : QueryListHandlerBase<GetResourceDefaultsQuery, ResourceDefaultModel>
    {
        private readonly IMapper _mapper;
        public GetResourceDefaultsHandler(DatabaseContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            _mapper = mapper;
        }

        protected override async Task<IQueryable<ResourceDefaultModel>> BuildQueryAsync(GetResourceDefaultsQuery query, RequestContextCore context)
        {
            var resourceDefaultQuery = Data.ResourceDefault.AsQueryable();
            if (!string.IsNullOrEmpty(query.Name))
            {
                resourceDefaultQuery = resourceDefaultQuery.Where(w => w.Name.Contains(query.Name));
            }
            if (!string.IsNullOrEmpty(query.Value))
            {
                resourceDefaultQuery = resourceDefaultQuery.Where(w => w.Value.Contains(query.Value));
            }
            if (!string.IsNullOrEmpty(query.Description))
            {
                resourceDefaultQuery = resourceDefaultQuery.Where(w => w.Description.Contains(query.Description));
            }
            return resourceDefaultQuery.ProjectTo<ResourceDefaultModel>(_mapper.ConfigurationProvider);
        }
    }
}
