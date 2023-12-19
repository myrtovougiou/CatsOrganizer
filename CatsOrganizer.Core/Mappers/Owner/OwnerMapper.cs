using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class OwnerMapper : BaseMapper<OwnerRequest, Owner>, IMapper<OwnerRequest, Owner>
    {
        public override Owner Map(OwnerRequest source)
        {
            if (source == null)
            {
                return null;
            }

            return new Owner
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
