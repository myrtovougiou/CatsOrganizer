using CatsOrganizer.Core.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Repositories
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task SaveChangesAsync(CancellationToken token = default)
        {
            await _context.SaveChangesAsync(token);
        }
    }
}
