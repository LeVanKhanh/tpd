using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.RequestCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore
{
    public abstract class HandlerCore<TRequest, TResponse> : IRequestHandler<TRequest, IResultCore<TResponse>>
        where TRequest : IRequestCore<TResponse>
    {
        protected readonly DatabaseContextCore Data;
        public HandlerCore(DatabaseContextCore db)
        {
            Data = db;
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
