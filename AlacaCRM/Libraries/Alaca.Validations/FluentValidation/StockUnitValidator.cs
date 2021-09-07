using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockUnitValidator : AbstractValidator<StockUnit>
    {
        public StockUnitValidator()
        {
            RuleFor(p => p.StockUnitName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Stok Birim Adı");
            RuleFor(p => p.StockUnitDefinitionId).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Birim");
            RuleFor(p => p.SpecialCode1).
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-1");
            RuleFor(p => p.SpecialCode2).
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-2");
            RuleFor(p => p.SpecialCode3).
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-3");
        }
    }

}
