using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;
using System;

namespace CatsOrganizer.Core.Dtos
{
    public class SterilizationDto : BaseAppointmentDto
    {
        public DateTime? StitchesRemovalDate { get; set; }
        public string MedicationInstructions { get; set; }
        public AppointmentType Type => AppointmentType.Sterilization;
    }
}
