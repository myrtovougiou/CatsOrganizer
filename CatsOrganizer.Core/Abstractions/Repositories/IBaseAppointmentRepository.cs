using CatsOrganizer.Core.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Repositories
{
    public interface IBaseAppointmentRepository<TEntity>  : IBaseEntityRepository<TEntity>
        where TEntity : BaseAppointment
    {
        Task<IEnumerable<TEntity>> GetByCatIdAsync(Guid catId, CancellationToken token = default);
    }
}
