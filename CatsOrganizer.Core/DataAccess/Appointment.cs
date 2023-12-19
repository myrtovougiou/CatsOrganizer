using CatsOrganizer.Core.Abstractions.DataAccess;

namespace CatsOrganizer.Core.DataAccess
{
    public class Appointment : BaseAppointment
    {
        public string Notes { get; set; }
    }
}
