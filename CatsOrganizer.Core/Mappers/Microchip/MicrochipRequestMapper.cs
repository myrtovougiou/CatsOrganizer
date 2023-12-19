using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class MicrochipRequestMapper : BaseAppointmentRequestMapper<Microchip, MicrochipRequest>
    {
        public override MicrochipRequest Map(Microchip source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.Position = source.Position;
            result.Number = source.Number;
            result.IsMunicipalityDeclared = source.IsMunicipalityDeclared;

            return result;
        }
    }
}
