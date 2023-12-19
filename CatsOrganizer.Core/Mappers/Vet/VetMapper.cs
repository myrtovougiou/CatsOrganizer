using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class VetMapper : BaseMapper<VetRequest, Vet>
    {
        public override Vet Map(VetRequest source)
        {
            if (source == null)
            {
                return null;
            }

            return new Vet
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Address = source.Address,
                PhoneNumber = source.PhoneNumber,
                MobilePhoneNumber = source.MobilePhoneNumber
            };
        }
    }
}
