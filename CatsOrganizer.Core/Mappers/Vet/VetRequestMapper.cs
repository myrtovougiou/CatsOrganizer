using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class VetRequestMapper : BaseMapper<Vet, VetRequest>
    {
        public override VetRequest Map(Vet source)
        {
            if (source == null)
            {
                return null;
            }

            return new VetRequest
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
