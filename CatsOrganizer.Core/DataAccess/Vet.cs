using System.Collections.Generic;
using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class Vet : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Cat> Cats { get; set; }
    }
}
