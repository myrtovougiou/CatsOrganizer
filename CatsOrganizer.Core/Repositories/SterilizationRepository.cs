using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class SterilizationRepository : BaseAppointmentRepository<Sterilization, CatDbContext>
    {
        public SterilizationRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
