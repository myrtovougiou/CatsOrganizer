using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class AppointmentDtoMapper : BaseAppointmentDtoMapper<Appointment, AppointmentDto>
    {
        public override AppointmentDto Map(Appointment source)
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
