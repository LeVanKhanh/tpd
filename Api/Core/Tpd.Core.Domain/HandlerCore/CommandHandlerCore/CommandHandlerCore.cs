using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore.CommandHandlerCore
{
    public abstract class CommandHandlerCore<TCommand> : HandlerCore<TCommand, int>
        where TCommand : ICommandCore
    {
        private readonly IMediator _mediator;
        public CommandHandlerCore(DatabaseContextCore db, IValidationService validationService, IMediator mediator)
            : base(db, validationService)
        {
            _mediator = mediator;
        }

        protected sealed override async Task<IResultCore<int>> Handle(TCommand command, RequestContextCore Context)
        {
            if (await TryBuildCommand(command, Context))
            {
                int result = Execute();
                SendNotification(command);
                return new ResultCore<int>
                {
                    Success = true,
                    Result = result
                };
            }
            else
            {
                return new ResultCore<int>
                {
                    Success = true,
                    ErrorMessages = command.Messages
                };
            }
        }

        protected virtual void SendNotification(TCommand command)
        {
            if (command.Notifications.Any())
            {
                foreach (var notification in command.Notifications)
                {
                    _mediator.Publish(notification);
                }
            }
        }

        private int Execute()
        {
            try
            {
                return Data.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(dbEx.InnerException.Message);
            }
        }

        protected abstract Task<bool> TryBuildCommand(TCommand command, RequestContextCore Context);
    }
}
