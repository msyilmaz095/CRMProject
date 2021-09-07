using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CurrencyValueValidator : AbstractValidator<CurrencyValue>
    {
        public CurrencyValueValidator()
        {
            RuleFor(p => p.CurrencyId).NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Para Birimi");
            RuleFor(p => p.Date).NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Kur Tarihi");
            RuleFor(p => p.Parity).NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Parite");
        }
    }

}
