using CatsOrganizer.Core.DataAccess;
using FluentValidation;

namespace CatsOrganizer.Core.Validators
{
    public class CatValidator : AbstractValidator<Cat>
    {
        public CatValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name must be set");
        }
    }
}
