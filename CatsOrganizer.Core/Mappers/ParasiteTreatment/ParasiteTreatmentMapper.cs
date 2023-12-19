using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class ParasiteTreatmentMapper : BaseAppointmentMapper<ParasiteTreatmentRequest, ParasiteTreatment>
    {
        public override ParasiteTreatment Map(ParasiteTreatmentRequest source)
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
