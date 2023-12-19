using CatsOrganizer.Core.Enums;
using System;

namespace CatsOrganizer.Core.Requests
{
    public class CatRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? VetId { get; set; }
        public string Picture { get; set; }
    }
}
