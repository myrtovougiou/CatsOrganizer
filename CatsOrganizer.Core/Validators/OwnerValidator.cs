using CatsOrganizer.Core.DataAccess;
using FluentValidation;

namespace CatsOrganizer.Core.Validators
{
    public class OwnerValidator : AbstractValidator<Owner>
    {
        public OwnerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name must be set.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name must be set.");
        }
    }
}
