using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class BloodTestDtoMapper : BaseAppointmentDtoMapper<BloodTest, BloodTestDto>
    {
        public override BloodTestDto Map(BloodTest source)
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
