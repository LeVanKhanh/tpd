using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using DataWriteEntities = Tpd.Example.Data.Write.Entities;
using DataReadEntities = Tpd.Example.Data.Read.Entities;
using Tpd.Example.Domain.HandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategoryHandlerMediator : DomainMediatorBase,
        IDomainMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryModel>
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
    }
}
