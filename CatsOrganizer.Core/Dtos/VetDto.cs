﻿using CatsOrganizer.Core.Abstractions.Dtos;

namespace CatsOrganizer.Core.Dtos
{
    public class VetDto : BaseEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
