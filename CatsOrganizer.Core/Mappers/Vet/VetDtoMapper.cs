using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class VetDtoMapper : BaseMapper<Vet, VetDto>
    {
        public override VetDto Map(Vet source)
        {
            if (source == null)
                return null;

            return new VetDto
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Address = source.Address,
                MobilePhoneNumber = source.MobilePhoneNumber,
                PhoneNumber = source.PhoneNumber
            };
        }
    }
}
