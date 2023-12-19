using CatsOrganizer.Core.Abstractions.Requests;

namespace CatsOrganizer.Core.Requests
{
    public class SurgeryRequest : BaseAppointmentRequest
    {
        public string Purpose { get; set; }
        public bool PostSurgeryMedicationRequired { get; set; }
        public string MedicationInstructions { get; set; }
    }
}
