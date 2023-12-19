using System;
using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class Sterilization : BaseAppointment
    {
        public DateTime? StitchesRemovalDate { get; set; }
        public string MedicationInstructions { get; set; }
    }
}
