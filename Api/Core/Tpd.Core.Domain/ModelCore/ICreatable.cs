using System;

namespace Tpd.Core.Domain.ModelCore
{
    public interface ICreatable
    {
        Guid Id { get; set; }
    }
}
