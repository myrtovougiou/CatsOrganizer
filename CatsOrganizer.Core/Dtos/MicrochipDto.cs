using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Dtos
{
    public class MicrochipDto : BaseAppointmentDto
    {
        public ChipPosition Position { get; set; }
        public string Number { get; set; }
        public bool IsMunicipalityDeclared { get; set; }
        public AppointmentType Type => AppointmentType.Microchip;
    }
}
