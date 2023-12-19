using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;
using System;

namespace CatsOrganizer.Core.Mappers
{
    public class CatRequestMapper : BaseMapper<Cat, CatRequest>
    {
        public override CatRequest Map(Cat source)
        {
            if (source == null)
            {
                return null;
            }

            return new CatRequest
            {
                Id = source.Id,
                Name = source.Name,
                BirthDate = source.BirthDate,
                Breed = source.Breed,
                Color = source.Color,
                OwnerId = source.OwnerId,
                Sex = source.Sex,
                VetId = source.VetId,
                Picture = source.Picture != null ? Convert.ToBase64String(source.Picture) : null
            };
        }
    }
}
