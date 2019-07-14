using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Example.Data.Read;
using Tpd.Example.Data.Read.Entities;
using Tpd.Example.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategoryGetItemsHandler : QueryListHandlerBase<GetMasterDataCategoriesQuery, MasterDataCategoryModel>
    {
        private DbSet<MasterDataCategory> Entities;
        private readonly IMapper _mapper;
        public MasterDataCategoryGetItemsHandler(DatabaseReadContext data, IValidationService validationService, IMapper mapper)
            : base(data, validationService)
        {
            Entities = data.Set<MasterDataCategory>();
            _mapper = mapper;
        }

        protected override async Task<IQueryable<MasterDataCategoryModel>> BuildQueryAsync(GetMasterDataCategoriesQuery query, RequestContextCore context)
        {
            var dataQuery = Entities.AsQueryable();
            if (!string.IsNullOrEmpty(query.Name))
            {
                dataQuery = dataQuery.Where(w => w.Name.Contains(query.Name));
            }
            if (!string.IsNullOrEmpty(query.Description))
            {
                dataQuery = dataQuery.Where(w => w.Description.Contains(query.Description));
            }
            return dataQuery.ProjectTo<MasterDataCategoryModel>(_mapper);
        }
    }
}
