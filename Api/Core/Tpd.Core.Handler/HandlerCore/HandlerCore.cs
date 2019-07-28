using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Core.Handler.RequestCore;
using Tpd.Core.Handler.ResultCore;

namespace Tpd.Core.Handler.HandlerCore
{
    public abstract class HandlerCore<TRequest, TResponse> : IRequestHandler<TRequest, IResultCore<TResponse>>
        where TRequest : IRequestCore<TResponse>
    {
        protected readonly DatabaseContextCore Data;
        protected readonly IValidationService ValidationService;
        public HandlerCore(DatabaseContextCore db, IValidationService validationService)
        {
            Data = db;
            ValidationService = validationService;
        }

        public async Task<IResultCore<TResponse>> Handle(TRequest request, CancellationToken cancellationToken = default)
        {
            //Gets request context
            var Context = new RequestContextCore
            {
                TenantId = request.Context.TenantId,
                UserId = request.Context.UserId
            };

            // Checks the request is valid or not
            if (await IsValidAll(request))
            {
                return await Handle(request, Context);
            }
            else
            {
                return new ResultCore<TResponse>
                {
                    Success = false,
                    ErrorMessages = request.Messages
                };
            }
        }

        protected async Task<bool> IsValidAll(TRequest request)
        {
            if (!request.IsValid())
            {
                return false;
            }
            return await IsValid(request);
        }

        protected virtual async Task<bool> IsValid(TRequest query)
        {
            query.Messages = new List<string> { };
            return true;
        }

        protected abstract Task<IResultCore<TResponse>> Handle(TRequest request, Data.RequestContextCore Context);
    }
}
