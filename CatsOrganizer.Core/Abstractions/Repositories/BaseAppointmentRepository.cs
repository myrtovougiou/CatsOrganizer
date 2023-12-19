using CatsOrganizer.Core.Abstractions.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Repositories
{
    public abstract class BaseAppointmentRepository<TEntity, TContext> : BaseEntityRepository<TEntity, TContext>, IBaseAppointmentRepository<TEntity>
        where TEntity : BaseAppointment
        where TContext: DbContext
    {
        public BaseAppointmentRepository(TContext context) : base(context)
        { }

        public async Task<IEnumerable<TEntity>> GetByCatIdAsync(Guid catId, CancellationToken token = default)
        {
            return await DbSet
                .Where(x => x.CatId == catId)
                .ToListAsync(token);
        }
    }
}
