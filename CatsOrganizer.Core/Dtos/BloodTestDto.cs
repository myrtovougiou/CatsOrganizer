using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;
using System;

namespace CatsOrganizer.Core.Dtos
{
    public class BloodTestDto : BaseAppointmentDto
    {
        public string Reason { get; set; }
        public DateTime? BloodResultsDate { get; set; }
        public bool IsNegative { get; set; }
        public AppointmentType Type => AppointmentType.BloodTest;
    }
}
