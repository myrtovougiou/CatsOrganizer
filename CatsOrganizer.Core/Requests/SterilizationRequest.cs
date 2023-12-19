using CatsOrganizer.Core.Abstractions.Requests;
using System;

namespace CatsOrganizer.Core.Requests
{
    public class SterilizationRequest : BaseAppointmentRequest
    {
        public DateTime? StitchesRemovalDate { get; set; }
        public bool PostSterilizationMedicationRequired { get; set; }
        public string MedicationInstructions { get; set; }
    }
}
