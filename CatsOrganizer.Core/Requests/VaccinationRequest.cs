using CatsOrganizer.Core.Abstractions.Requests;

namespace CatsOrganizer.Core.Requests
{
    public class VaccinationRequest : BaseAppointmentRequest
    {
        public string VaccineName { get; set; }
        public string VaccineManufacturer { get; set; }
        public string Disease { get; set; }
        public double CatWeight { get; set; }
    }
}
