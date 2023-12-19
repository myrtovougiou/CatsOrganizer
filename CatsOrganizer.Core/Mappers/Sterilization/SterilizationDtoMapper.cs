using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class SterilizationDtoMapper : BaseAppointmentDtoMapper<Sterilization, SterilizationDto>
    {
        public override SterilizationDto Map(Sterilization source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.StitchesRemovalDate = source.StitchesRemovalDate;
            result.MedicationInstructions = source.MedicationInstructions;

            return result;
        }
    }
}
