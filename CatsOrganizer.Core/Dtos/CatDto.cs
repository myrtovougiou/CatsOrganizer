using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;
using System;

namespace CatsOrganizer.Core.Dtos
{
    public class CatDto : BaseEntityDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Picture { get; set; }
        public Guid? OwnerId { get; set; }
        public OwnerDto Owner { get; set; }
        public Guid? VetId { get; set; }
    }
}
