using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class ParasiteTreatmentRequestMapper : BaseAppointmentRequestMapper<ParasiteTreatment, ParasiteTreatmentRequest>
    {
        public override ParasiteTreatmentRequest Map(ParasiteTreatment source)
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
