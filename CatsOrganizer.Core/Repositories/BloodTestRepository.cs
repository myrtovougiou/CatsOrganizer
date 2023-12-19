using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Repositories
{
    public class BloodTestRepository : BaseAppointmentRepository<BloodTest, CatDbContext>
    {
        public BloodTestRepository(CatDbContext context) : base(context)
        {
            
        }
    }
}
