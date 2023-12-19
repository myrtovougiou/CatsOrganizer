using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class MicrochipDtoMapper : BaseAppointmentDtoMapper<Microchip, MicrochipDto>
    {
        public override MicrochipDto Map(Microchip source)
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
