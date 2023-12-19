using CatsOrganizer.Core.Abstractions.DataAccess;
using FluentValidation;

namespace CatsOrganizer.Core.Abstractions.Validators
{
    public abstract class BaseAppointmentValidator<TEntity> : AbstractValidator<TEntity>
        where TEntity : BaseAppointment
    {
        public BaseAppointmentValidator()
        {
            RuleFor(x => x.ScheduledDate).NotEmpty().WithMessage("Scheduled Date must be set");
            RuleFor(x => x.CatId).NotEmpty().WithMessage("Cat must be set");
        }
    }
}
