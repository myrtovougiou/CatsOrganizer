using CatsOrganizer.Core.Abstractions.Requests;
using System;

namespace CatsOrganizer.Core.Requests
{
    public class BloodTestRequest : BaseAppointmentRequest
    {
        public string Reason { get; set; }
        public DateTime? BloodResultsDate { get; set; }
        public bool IsNegative { get; set; }
    }
}
