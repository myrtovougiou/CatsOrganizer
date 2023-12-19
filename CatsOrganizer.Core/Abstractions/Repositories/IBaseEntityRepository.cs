using CatsOrganizer.Core.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Repositories
{
    public interface IBaseEntityRepository<TEntity> 
        where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default);
        Task<TEntity> GetAsync(Guid id, CancellationToken token = default);
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default);
        Task<TEntity> RemoveAsync(Guid id, CancellationToken token = default);
        TEntity Update(TEntity entity, TEntity updatedEntity);
    }
}
