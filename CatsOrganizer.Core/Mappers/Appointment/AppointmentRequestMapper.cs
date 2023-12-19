using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class AppointmentRequestMapper : BaseAppointmentRequestMapper<Appointment, AppointmentRequest>
    {
        public override AppointmentRequest Map(Appointment source)
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
