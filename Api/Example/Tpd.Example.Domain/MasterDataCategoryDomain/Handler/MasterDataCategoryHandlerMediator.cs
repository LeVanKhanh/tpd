using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.HandlerCore;
using Tpd.Core.Handler.ResultCore;
using Tpd.Example.Domain.HandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;
using Tpd.Example.Domain.MasterDataCategoryDomain.Result;
using DataReadEntities = Tpd.Example.Data.Read.Entities;
using DataWriteEntities = Tpd.Example.Data.Write.Entities;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class MasterDataCategoryHandlerMediator : DomainMediatorBase,
        IHandlerMediator<MasterDataCategoryModel, MasterDataCategoryModel, MasterDataCategoryResult, MasterDataCategoryResult, GetMasterDataCategoriesQuery>
    {
        public MasterDataCategoryHandlerMediator(IServiceProvider serviceProvider, IMediator mediator)
            : base(serviceProvider, mediator)
        {

        }

        public async Task<IResultCore<int>> Create(MasterDataCategoryModel model)
        {
            return await Create<DataWriteEntities.MasterDataCategory, MasterDataCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Update(MasterDataCategoryModel model)
        {
            return await Update<DataWriteEntities.MasterDataCategory, MasterDataCategoryModel>(model);
        }

        public async Task<IResultCore<int>> Remove(Guid id)
        {
            return await Remove<DataWriteEntities.MasterDataCategory>(id);
        }

        public async Task<IResultCore<MasterDataCategoryResult>> GetItem(Guid id)
        {
            return await GetItem<DataReadEntities.MasterDataCategory, MasterDataCategoryResult>(id);
        }

        public async Task<IResultCore<PagedResultCore<MasterDataCategoryResult>>> GetItems(GetMasterDataCategoriesQuery query)
        {
            return await base.GetItems(query);
        }
    }
}
