using AutoMapper;
using MediatR;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Core.Domain.ModelCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandCreateHandlerBase<TEntity, TModel> : CommandCreateHandlerCore<TEntity, TModel>
        where TEntity : EntityCore
        where TModel : IEntityModel
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandCreateHandlerBase(DatabaseWriteContext data, IValidationService validationService, IMediator mediator, IMapper mapper)
          : base(data, validationService, mediator, mapper)
        {
            Data = data;
        }
    }
}
