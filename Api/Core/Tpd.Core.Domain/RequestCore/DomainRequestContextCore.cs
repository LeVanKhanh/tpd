using System;

namespace Tpd.Core.Domain.RequestCore
{
    public class DomainRequestContextCore
    {
        public Guid UserId { get; set; }
        public Guid TenantId { get; set; }
    }
}
