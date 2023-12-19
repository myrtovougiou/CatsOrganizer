using CatsOrganizer.Core.Abstractions.Validators;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Validators
{
    public class SurgeryValidator : BaseAppointmentValidator<Surgery>
    {
        public SurgeryValidator() : base()
        { }
    }
}
