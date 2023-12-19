using CatsOrganizer.Core.Abstractions.Validators;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Validators
{
    public class AppointmentValidator : BaseAppointmentValidator<Appointment>
    {
        public AppointmentValidator(): base()
        { }
    }
}
