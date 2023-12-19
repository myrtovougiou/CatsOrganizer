using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class SurgeryRepository : BaseAppointmentRepository<Surgery, CatDbContext>
    {
        public SurgeryRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
