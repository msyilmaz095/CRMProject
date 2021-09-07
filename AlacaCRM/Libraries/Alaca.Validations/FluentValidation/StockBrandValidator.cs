using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockBrandValidator : AbstractValidator<StockBrand>
    {
        public StockBrandValidator()
        {
            RuleFor(p => p.StockBrandCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Marka Kodu");
            RuleFor(p => p.StockBrandName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Marka Adı");
        }
    }

}
