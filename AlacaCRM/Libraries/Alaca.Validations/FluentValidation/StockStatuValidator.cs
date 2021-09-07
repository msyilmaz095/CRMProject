using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockStatuValidator : AbstractValidator<StockStatu>
    {
        public StockStatuValidator()
        {
            RuleFor(p => p.StockStatuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(5).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Stok Durum");
        }
    }

}
