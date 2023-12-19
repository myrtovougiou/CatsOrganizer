using System;
using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class Surgery : BaseAppointment
    {
        public string Purpose { get; set; }
        public string MedicationInstructions { get; set; }
    }
}
