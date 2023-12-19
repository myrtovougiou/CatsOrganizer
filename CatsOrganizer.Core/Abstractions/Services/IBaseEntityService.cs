using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Services
{
    public interface IBaseEntityService<TRequest, TResult>
        where TRequest : class
    {
        Task<IEnumerable<TResult>> GetAllAsync(CancellationToken token = default);
        Task<TResult> GetByIdAsync(Guid id, CancellationToken token = default);
        Task<TResult> CreateAsync(TRequest request, CancellationToken token = default);
        Task<TResult> UpdateAsync(Guid id, JsonPatchDocument<TRequest> patchDocument, CancellationToken token = default);
        Task DeleteAsync(Guid id, CancellationToken token = default);
    }
}
