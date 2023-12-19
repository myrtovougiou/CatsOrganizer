using System;
using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class BloodTest : BaseAppointment
    {
        public string Reason { get; set; }
        public DateTime? BloodResultsDate { get; set; }
        public bool IsNegative { get; set; }
    }
}
