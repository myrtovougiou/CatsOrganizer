using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Enums;

namespace CatsOrganizer.Core.DataAccess
{
    public class ParasiteTreatment : BaseAppointment
    {
        public string Medicine { get; set; }
        public ParasitesType ParasitesType { get; set; }
    }
}
