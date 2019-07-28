using MediatR;
using System.Collections.Generic;
using Tpd.Core.Handler.ResultCore;

namespace Tpd.Core.Handler.RequestCore
{
    public interface IRequestCore : IRequest
    {
        // Validate the request.
        bool IsValid();
        //This property will contain validation/error message(s) during handle a request.
        List<string> Messages { get; set; }
        //Request context.
        HandlerRequestContextCore Context { get; set; }
    }

    public interface IRequestCore<TResponse> : IRequest<IResultCore<TResponse>>
    {
        // Validate the request.
        bool IsValid();
        //This property will contain validation/error message(s) during handle a request.
        List<string> Messages { get; set; }
        //Request context.
        HandlerRequestContextCore Context { get; set; }
    }
}
