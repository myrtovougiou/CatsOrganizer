using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;
using System;

namespace CatsOrganizer.Core.Repositories
{
    public class OwnerRepository : BaseEntityRepository<Owner, CatDbContext>
    {
        public OwnerRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
