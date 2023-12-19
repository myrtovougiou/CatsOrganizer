using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Dtos
{
    public class SurgeryDto : BaseAppointmentDto
    {
        public string Purpose { get; set; }
        public string MedicationInstructions { get; set; }
        public AppointmentType Type => AppointmentType.Surgery;
    }
}
