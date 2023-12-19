using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class VaccinationRepository : BaseAppointmentRepository<Vaccination, CatDbContext>
    {
        public VaccinationRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
