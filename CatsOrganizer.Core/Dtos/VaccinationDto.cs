using CatsOrganizer.Core.Abstractions.Dtos;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.Dtos
{
    public class VaccinationDto : BaseAppointmentDto
    {
        public string VaccineName { get; set; }
        public string VaccineManufacturer { get; set; }
        public string Disease { get; set; }
        public double CatWeight { get; set; }
        public AppointmentType Type => AppointmentType.Vaccination;
    }
}
