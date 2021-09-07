using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class FactoryValidator : AbstractValidator<Factory>
    {
        public FactoryValidator()
        {
            RuleFor(p => p.FactoryName).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Fabrika Adı");
            
        }
    }
}
