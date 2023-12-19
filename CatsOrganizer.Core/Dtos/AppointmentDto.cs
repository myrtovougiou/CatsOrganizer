using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Dtos
{
    public class AppointmentDto : BaseAppointmentDto
    {
        public string Notes { get; set; }
        public AppointmentType Type => AppointmentType.Other;
    }
}
