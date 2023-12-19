using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class Vaccination : BaseAppointment
    {
        public string VaccineName { get; set; }
        public string VaccineManufacturer { get; set; }
        public string Disease { get; set; }
        public double CatWeight { get; set; }
    }
}
