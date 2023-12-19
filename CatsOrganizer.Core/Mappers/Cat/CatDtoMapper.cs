using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;
using System;

namespace CatsOrganizer.Core.Mappers
{
    public class CatDtoMapper : BaseMapper<Cat, CatDto>
    {
        private readonly IMapper<Owner, OwnerDto> _ownerDtoMapper;

        public CatDtoMapper(IMapper<Owner, OwnerDto> ownerDtoMapper)
        {
            _ownerDtoMapper = ownerDtoMapper ?? throw new ArgumentNullException(nameof(ownerDtoMapper));
        }

        public override CatDto Map(Cat source)
        {
            if (source == null)
            {
                return null;
            }

            return new CatDto
            {
                Id = source.Id,
                Name = source.Name,
                BirthDate = source.BirthDate,
                Breed = source.Breed,
                Color = source.Color,
                OwnerId = source.OwnerId,
                Sex = source.Sex,
                VetId = source.VetId,
                Owner = _ownerDtoMapper.Map(source.Owner),
                Picture = source.Picture != null ? Convert.ToBase64String(source.Picture) : null
            };
        }
    }
}
