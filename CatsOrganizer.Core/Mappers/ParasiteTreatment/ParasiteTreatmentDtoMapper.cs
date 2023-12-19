using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class ParasiteTreatmentDtoMapper : BaseAppointmentDtoMapper<ParasiteTreatment, ParasiteTreatmentDto>
    {
        public override ParasiteTreatmentDto Map(ParasiteTreatment source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.Medicine = source.Medicine;
            result.ParasitesType = source.ParasitesType;

            return result;
        }
    }
}
