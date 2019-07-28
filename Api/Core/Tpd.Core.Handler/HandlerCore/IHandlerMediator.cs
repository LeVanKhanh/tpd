using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Handler.ModelCore;
using Tpd.Core.Handler.RequestCore.QueryCore;
using Tpd.Core.Handler.ResultCore;

namespace Tpd.Core.Handler.HandlerCore
{
    public interface IHandlerMediator<TModelCreate, TModelUpdate, TGetItemResponse, TGetItemsResponse, TQuery>
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
        where TQuery: IQueryListCore<TGetItemsResponse>
    {
        IMediator Mediator { get; set; }
        Task<IResultCore<int>> Create(TModelCreate model);
        Task<IResultCore<int>> Update(TModelUpdate model);
        Task<IResultCore<int>> Remove(Guid id);
        Task<IResultCore<TGetItemResponse>> GetItem(Guid id);
        Task<IResultCore<PagedResultCore<TGetItemsResponse>>> GetItems(TQuery query);
    }
}
