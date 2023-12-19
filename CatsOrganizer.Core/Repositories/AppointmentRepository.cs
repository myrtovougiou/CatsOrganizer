using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class AppointmentRepository : BaseAppointmentRepository<Appointment, CatDbContext>
    {
        public AppointmentRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
