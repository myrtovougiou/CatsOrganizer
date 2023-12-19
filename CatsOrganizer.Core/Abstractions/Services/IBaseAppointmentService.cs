using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Services
{
    public interface IBaseAppointmentService<TRequest, TResult> : IBaseEntityService<TRequest, TResult>
        where TRequest : class
    {
        Task<IEnumerable<TResult>> GetByCatIdAsync(Guid id, CancellationToken token = default);
    }
}
