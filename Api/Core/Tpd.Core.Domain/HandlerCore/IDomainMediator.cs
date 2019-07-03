using MediatR;
using System;
using System.Threading.Tasks;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Core.Domain.HandlerCore
{
    public interface IDomainMediator<TModelCreate, TModelUpdate>
        where TModelCreate : IEntityModel
        where TModelUpdate : IEntityModel
    {
        IMediator Mediator { get; set; }
        Task<int> Create(TModelCreate model);
        Task<int> Update(TModelCreate model);
        Task<int> Remove(Guid id);
    }
}
