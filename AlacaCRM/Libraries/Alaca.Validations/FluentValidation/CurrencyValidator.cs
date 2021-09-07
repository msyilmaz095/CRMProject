using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CurrencyValidator : AbstractValidator<Currency>
    {
        public CurrencyValidator()
        {
            RuleFor(p => p.CurrencyCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(5).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kod");
            RuleFor(p => p.CurrencyName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(10).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ad");
        }
    }

}
