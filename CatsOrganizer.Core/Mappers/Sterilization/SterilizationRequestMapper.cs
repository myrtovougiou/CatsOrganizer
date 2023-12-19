using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class SterilizationRequestMapper : BaseAppointmentRequestMapper<Sterilization, SterilizationRequest>
    {
        public override SterilizationRequest Map(Sterilization source)
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
