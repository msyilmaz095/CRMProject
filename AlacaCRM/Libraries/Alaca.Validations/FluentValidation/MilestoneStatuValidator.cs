using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class MilestoneStatuValidator : AbstractValidator<MilestoneStatu>
    {
        public MilestoneStatuValidator()
        {
            RuleFor(p => p.MilestoneStatuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ad");
        }
    }

}
