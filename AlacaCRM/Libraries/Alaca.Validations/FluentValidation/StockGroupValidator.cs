using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockGroupValidator : AbstractValidator<StockGroup>
    {
        public StockGroupValidator()
        {
            RuleFor(p => p.StockGroupCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Grup Kodu");
            RuleFor(p => p.StockGroupName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Grup Adı");
        }
    }

}
