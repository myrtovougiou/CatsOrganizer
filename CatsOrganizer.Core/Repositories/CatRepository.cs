using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace CatsOrganizer.Core.Repositories
{
    public class CatRepository : BaseEntityRepository<Cat, CatDbContext>
    {
        public CatRepository(CatDbContext context) : base(context)
        {       
        }

        public override async Task<IEnumerable<Cat>> GetAllAsync(CancellationToken token = default)
        {
            return await DbSet
                .Include("Owner")
                .ToListAsync(token);
        }

        public override async Task<Cat> GetAsync(Guid id, CancellationToken token = default)
        {
            return await DbSet
                .Where(x => x.Id == id)
                .Include("Owner")
                .FirstOrDefaultAsync(token);
        }
    }
}
