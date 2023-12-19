using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;

namespace CatsOrganizer.Core.Mappers
{
    public class OwnerDtoMapper : BaseMapper<Owner, OwnerDto>
    {
        public override OwnerDto Map(Owner source)
        {
            if (source == null)
            {
                return null;
            }

            return new OwnerDto
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Address = source.Address,
                PhoneNumber = source.PhoneNumber
            };
        }
    }
}
