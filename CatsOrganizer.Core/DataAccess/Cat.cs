using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Enums;
using System;
using System.Collections.Generic;

namespace CatsOrganizer.Core.DataAccess
{
    public class Cat : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public byte[] Picture { get; set; }
        public Guid? VetId { get; set; }
        public Vet Vet { get; set; }
        public Guid? OwnerId { get; set; }
        public Owner Owner { get; set; }
        public Microchip Microchip { get; set; }
        public Sterilization Sterilization { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<BloodTest> BloodTests { get; set; }
        public ICollection<ParasiteTreatment> ParasiteTreatments { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public ICollection<Vaccination> Vaccinations { get; set; }
    }
}
