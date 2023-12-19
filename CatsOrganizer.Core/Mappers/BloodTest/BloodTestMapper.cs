using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class BloodTestMapper : BaseAppointmentMapper<BloodTestRequest, BloodTest>
    {
        public override BloodTest Map(BloodTestRequest source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.Reason = source.Reason;
            result.BloodResultsDate = source.BloodResultsDate;
            result.IsNegative = source.IsNegative;

            return result;
        }
    }
}
