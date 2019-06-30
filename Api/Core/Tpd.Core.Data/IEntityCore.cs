using System;

namespace Tpd.Core.Data
{
    public interface IEntityCore
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid CreatedBy { get; set; }
        Guid UpdatedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
