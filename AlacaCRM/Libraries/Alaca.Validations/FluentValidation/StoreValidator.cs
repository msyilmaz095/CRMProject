using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StoreValidator : AbstractValidator<Store>
    {
        public StoreValidator()
        {
            RuleFor(p => p.StoreCode).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Depo Kod");
            RuleFor(p => p.StoreName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Depo Adı");
            RuleFor(p => p.StoreFactoryId).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Depo Fabrikası");
        }
    }
}
