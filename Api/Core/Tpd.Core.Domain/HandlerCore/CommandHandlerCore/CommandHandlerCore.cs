using Microsoft.EntityFrameworkCore;
using System;
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
        public CommandHandlerCore(DatabaseContextCore db, IValidationService validationService)
            : base(db, validationService)
        {

        }

        protected sealed override async Task<IResultCore<int>> Handle(TCommand command, RequestContextCore Context)
        {
            if (await TryBuildCommand(command, Context))
            {
                int result = Execute();
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
