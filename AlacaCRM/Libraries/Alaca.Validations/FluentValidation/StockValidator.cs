using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(p => p.StockName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MinimumLength(5).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Stok Adı");
            RuleFor(p => p.StockCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MinimumLength(5).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Stok Kod");
        }
    }
}
