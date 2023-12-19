using System;

namespace CatsOrganizer.Core.Requests
{
    public class OwnerRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
