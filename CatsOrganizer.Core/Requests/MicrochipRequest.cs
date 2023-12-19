using CatsOrganizer.Core.Abstractions.Requests;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Requests
{
    public class MicrochipRequest : BaseAppointmentRequest
    {
        public ChipPosition Position { get; set; }
        public string Number { get; set; }
        public bool IsMunicipalityDeclared { get; set; }
    }
}
