using CatsOrganizer.Core.Abstractions.DataAccess;
using System.Collections.Generic;

namespace CatsOrganizer.Core.DataAccess
{
    public class Owner : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Cat> Cats { get; set; }
    }
}
