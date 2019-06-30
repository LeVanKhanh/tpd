using System.Collections.Generic;

namespace Tpd.Core.Domain.RequestCore
{
    public abstract class RequestCore : IRequestCore
    {
        public RequestCore()
        {
            Context = new DomainRequestContextCore();
            Messages = new List<string>();
        }
        //Request context.
        public DomainRequestContextCore Context { get; set; }
        //This property will contain validation/error message(s) during handle a request.
        public List<string> Messages { get; set; }
        // Validate the request.
        public virtual bool IsValid()
        {
            return true;
        }
    }

    public abstract class RequestCore<TResponse> : IRequestCore<TResponse>
    {
        public RequestCore()
        {
            Context = new DomainRequestContextCore();
            Messages = new List<string>();
        }
        //Request context.
        public DomainRequestContextCore Context { get; set; }
        //This property will contain validation/error message(s) during handle a request.
        public List<string> Messages { get; set; }
        // Validate the request.
        public virtual bool IsValid()
        {
            return true;
        }
    }
}
