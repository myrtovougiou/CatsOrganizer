using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class SurgeryRequestMapper : BaseAppointmentRequestMapper<Surgery, SurgeryRequest>
    {
        public override SurgeryRequest Map(Surgery source)
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
