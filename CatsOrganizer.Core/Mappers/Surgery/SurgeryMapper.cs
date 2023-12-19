using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class SurgeryMapper : BaseAppointmentMapper<SurgeryRequest, Surgery>
    {
        public override Surgery Map(SurgeryRequest source)
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
