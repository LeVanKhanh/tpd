using System;

namespace Tpd.Core.Data
{
    public class RequestContextCore
    {
        public Guid UserId { get; set; }
        public Guid TenantId { get; set; }
    }
}
