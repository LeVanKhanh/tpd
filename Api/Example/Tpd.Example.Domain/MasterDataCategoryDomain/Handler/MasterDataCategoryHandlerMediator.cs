using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.HandlerCore;
using Tpd.Example.Data.Write.Entities;
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
            return await Create<MasterDataCategory, MasterDataCategoryModel>(model);
        }


        public async Task<int> Update(MasterDataCategoryModel model)
        {
            return await Update<MasterDataCategory, MasterDataCategoryModel>(model);
        }

        public async Task<int> Remove(Guid id)
        {
            return await Remove<MasterDataCategory>(id);
        }

        public async Task<MasterDataCategoryModel> GetItem(Guid id)
        {
            return await GetItem<MasterDataCategory, MasterDataCategoryModel>(id);
        }
    }
}
