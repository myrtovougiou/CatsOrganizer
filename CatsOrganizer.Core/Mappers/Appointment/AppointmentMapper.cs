using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class AppointmentMapper : BaseAppointmentMapper<AppointmentRequest, Appointment>
    {
        public override Appointment Map(AppointmentRequest source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.Notes = source.Notes;

            return result;
        }
    }
}
