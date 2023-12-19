using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class VetRepository : BaseEntityRepository<Vet, CatDbContext>
    {
        public VetRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
