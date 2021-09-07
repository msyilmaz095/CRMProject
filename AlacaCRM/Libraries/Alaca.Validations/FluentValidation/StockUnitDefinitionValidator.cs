using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockUnitDefinitionValidator : AbstractValidator<StockUnitDefinition>
    {
        public StockUnitDefinitionValidator()
        {
            RuleFor(p => p.StockUnitDefinitionCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Grup Kodu");
            RuleFor(p => p.StockUnitDefinitionName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(80).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Grup Adı");
        }
    }

}
