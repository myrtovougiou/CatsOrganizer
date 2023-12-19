using CatsOrganizer.Core.Abstractions.Validators;
using CatsOrganizer.Core.DataAccess;

namespace CatsOrganizer.Core.Validators
{
    public class VaccinationValidator : BaseAppointmentValidator<Vaccination>
    {
        public VaccinationValidator() : base()
        { }
    }
}
