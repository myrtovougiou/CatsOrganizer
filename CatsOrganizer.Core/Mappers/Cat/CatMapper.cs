using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;
using System;

namespace CatsOrganizer.Core.Mappers
{
    public class CatMapper : BaseMapper<CatRequest, Cat>
    {
        public override Cat Map(CatRequest source)
        {
            if (source == null)
            {
                return null;
            }

            return new Cat
            {
                Id = source.Id,
                Name = source.Name,
                BirthDate = source.BirthDate,
                Breed = source.Breed,
                Color = source.Color,
                OwnerId = source.OwnerId,
                Sex = source.Sex,
                VetId = source.VetId,
                Picture = Convert.FromBase64String(source.Picture.Split(",")[1])
            };
        }
    }
}
