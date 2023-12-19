using CatsOrganizer.Core.Abstractions.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Repositories
{
    public abstract class BaseEntityRepository<TEntity, TContext> : IBaseEntityRepository<TEntity>
        where TEntity : BaseEntity
        where TContext: DbContext
    {
        protected DbSet<TEntity> DbSet { get; private set; }
        protected TContext DbContext { get; private set; }

        public BaseEntityRepository(TContext context)
        {
            DbContext = context ?? throw new ArgumentNullException(nameof(context));
            DbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default)
        {
            return await DbSet.ToListAsync(token);
        }

        public virtual async Task<TEntity> GetAsync(Guid id, CancellationToken token = default)
        {
            return await DbSet.FindAsync(id, token);
        }

        public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token)
        {
            await DbSet.AddAsync(entity, token);
            return entity;
        }

        public async Task<TEntity> RemoveAsync(Guid id, CancellationToken token)
        {
            var entity = await GetAsync(id, token);

            if (entity == null)
            {
                return null;
            }

            var result = DbSet.Remove(entity);
            return result.Entity;
        }

        public TEntity Update(TEntity entity, TEntity updatedEntity)
        {
            DbContext.Entry(entity).CurrentValues.SetValues(updatedEntity);
            return entity;
        }
    }
}
