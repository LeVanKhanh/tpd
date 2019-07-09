using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.ModelCore;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore
{
    public interface IDomainMediator<TModelCreate, TModelUpdate, TResponse, TQuery>
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
        where TQuery: IQueryListCore<TResponse>
    {
        IMediator Mediator { get; set; }
        Task<int> Create(TModelCreate model);
        Task<int> Update(TModelUpdate model);
        Task<int> Remove(Guid id);
        Task<TResponse> GetItem(Guid id);
        Task<IResultCore<PagedResultCore<TResponse>>> GetItems(TQuery query);
    }
}
