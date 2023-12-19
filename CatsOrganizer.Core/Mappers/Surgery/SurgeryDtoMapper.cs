using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class SurgeryDtoMapper : BaseAppointmentDtoMapper<Surgery, SurgeryDto>
    {
        public override SurgeryDto Map(Surgery source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.Purpose = source.Purpose;
            result.MedicationInstructions = source.MedicationInstructions;

            return result;
        }
    }
}
