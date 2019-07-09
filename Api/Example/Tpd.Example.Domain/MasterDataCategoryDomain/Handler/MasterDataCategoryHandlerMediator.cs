using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Core.Domain.ResultCore;
using Tpd.Example.Domain.HandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;
using DataReadEntities = Tpd.Example.Data.Read.Entities;
using DataWriteEntities = Tpd.Example.Data.Write.Entities;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategoryHandlerMediator : DomainMediatorBase,
        IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel, GetMasterDataCategoriesQuery>
    {
        public MasterDataCategoryHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<int> Create(MasterDataCategoryModel model)
        {
            return await Create<DataWriteEntities.MasterDataCategory, MasterDataCategoryModel>(model);
        }

        public async Task<int> Update(MasterDataCategoryModel model)
        {
            return await Update<DataWriteEntities.MasterDataCategory, MasterDataCategoryModel>(model);
        }

        public async Task<int> Remove(Guid id)
        {
            return await Remove<DataWriteEntities.MasterDataCategory>(id);
        }

        public async Task<MasterDataCategoryModel> GetItem(Guid id)
        {
            return await GetItem<DataReadEntities.MasterDataCategory, MasterDataCategoryModel>(id);
        }

        public async Task<IResultCore<PagedResultCore<MasterDataCategoryModel>>> GetItems(GetMasterDataCategoriesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
