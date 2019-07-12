using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore
{
    public interface IDomainMediator<TModelCreate, TModelUpdate, TGetItemResponse, TGetItemsResponse, TQuery>
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
        where TQuery: IQueryListCore<TGetItemsResponse>
    {
        IMediator Mediator { get; set; }
        Task<int> Create(TModelCreate model);
        Task<int> Update(TModelUpdate model);
        Task<int> Remove(Guid id);
        Task<TGetItemResponse> GetItem(Guid id);
        Task<IResultCore<PagedResultCore<TGetItemsResponse>>> GetItems(TQuery query);
    }
}
