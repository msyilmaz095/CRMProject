using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class UnitValidator : AbstractValidator<Unit>
    {
        public UnitValidator()
        {
            RuleFor(p => p.UnitName).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Birim Adı");
            RuleFor(p => p.Description).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(250).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Birim Açıklaması");

        }
    }
}
