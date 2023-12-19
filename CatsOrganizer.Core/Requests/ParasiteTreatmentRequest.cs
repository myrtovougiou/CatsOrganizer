using CatsOrganizer.Core.Abstractions.Requests;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Requests
{
    public class ParasiteTreatmentRequest : BaseAppointmentRequest
    {
        public string Medicine { get; set; }
        public ParasitesType ParasitesType { get; set; }
    }
}
