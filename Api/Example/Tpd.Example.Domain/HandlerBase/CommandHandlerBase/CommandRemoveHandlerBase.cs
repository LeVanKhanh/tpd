﻿using Tpd.Core.Data;
using Tpd.Core.Domain.HandlerCore.CommandHandlerCore;
using Tpd.Example.Data.Write;

namespace Tpd.Example.Domain.HandlerBase.CommandHandlerBase
{
    public class CommandRemoveHandlerBase<TEntity> : CommandRemoveHandlerCore<TEntity>
        where TEntity : EntityCore
    {
        protected new DatabaseWriteContext Data { get; set; }
        public CommandRemoveHandlerBase(DatabaseWriteContext data)
          : base(data)
        {
            Data = data;
        }
    }
}
