using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class OwnerRequestMapper : BaseMapper<Owner, OwnerRequest>, IMapper<Owner, OwnerRequest>
    {
        public override OwnerRequest Map(Owner source)
        {
            if (source == null)
            {
                return null;
            }

            return new OwnerRequest
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
