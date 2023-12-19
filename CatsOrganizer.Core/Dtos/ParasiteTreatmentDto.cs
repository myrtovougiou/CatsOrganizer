using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Dtos
{
    public class ParasiteTreatmentDto : BaseAppointmentDto
    {
        public string Medicine { get; set; }
        public ParasitesType ParasitesType { get; set; }
        public AppointmentType Type => AppointmentType.ParasiteTreatment;
    }
}
