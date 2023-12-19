using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class ParasiteTreatmentRepository : BaseAppointmentRepository<ParasiteTreatment, CatDbContext>
    {
        public ParasiteTreatmentRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
