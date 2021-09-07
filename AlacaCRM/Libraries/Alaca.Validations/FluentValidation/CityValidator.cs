using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(p => p.CityCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(10).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Şehir Kodu");
            RuleFor(p => p.CityName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Şehir Adı");
        }
    }

}
