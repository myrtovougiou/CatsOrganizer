using CatsOrganizer.Core.Abstractions.Requests;

namespace CatsOrganizer.Core.Requests
{
    public class AppointmentRequest : BaseAppointmentRequest
    {
        public string Notes { get; set; }
    }
}
