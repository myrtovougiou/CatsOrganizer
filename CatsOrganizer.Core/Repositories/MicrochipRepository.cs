using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class MicrochipRepository : BaseAppointmentRepository<Microchip, CatDbContext>
    {
        public MicrochipRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
