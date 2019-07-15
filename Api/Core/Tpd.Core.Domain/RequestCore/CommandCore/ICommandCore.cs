﻿using MediatR;
using System.Collections.Generic;

namespace Tpd.Core.Domain.RequestCore.CommandCore
{
    public interface ICommandCore : IRequestCore<int>
    {
        List<INotification> Notifications { get; set; }
    }
}
