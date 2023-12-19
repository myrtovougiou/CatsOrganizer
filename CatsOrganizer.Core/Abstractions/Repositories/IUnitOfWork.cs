using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Repositories
{
    public interface IUnitOfWork<TContext>
        where TContext : DbContext
    {
        Task SaveChangesAsync(CancellationToken token = default);
    }
}
