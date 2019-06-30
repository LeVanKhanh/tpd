using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tpd.Core.Data
{
    public static class DbSetExtension
    {
        public static EntityEntry<TEntity> AddWithContext<TEntity>(this DbSet<TEntity> dbset, RequestContextCore context, TEntity entity)
            where TEntity : EntityCore
        {
            var currentDateTime = DateTime.Now;
            entity.CreatedAt = currentDateTime;
            entity.UpdatedAt = currentDateTime;
            entity.CreatedBy = context.UserId;
            entity.UpdatedBy = context.UserId;
            return dbset.Add(entity);
        }

        public static Task<EntityEntry<TEntity>> AddWithContextAsync<TEntity>(this DbSet<TEntity> dbset, RequestContextCore context, TEntity entity, CancellationToken cancellationToken = default)
             where TEntity : EntityCore
        {
            var currentDateTime = DateTime.Now;
            entity.CreatedAt = currentDateTime;
            entity.UpdatedAt = currentDateTime;
            entity.CreatedBy = context.UserId;
            entity.UpdatedBy = context.UserId;
            return dbset.AddAsync(entity, cancellationToken);
        }

        public static EntityEntry<TEntity> UpdateWithContext<TEntity>(this DbSet<TEntity> dbset, RequestContextCore context, TEntity entity)
             where TEntity : EntityCore
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = context.UserId;
            return dbset.Update(entity);
        }
    }
}
