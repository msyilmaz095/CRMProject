using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ShelfValidator : AbstractValidator<Shelf>
    {
        public ShelfValidator()
        {
            RuleFor(p => p.ShelfName).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Raf Adı");
            RuleFor(p => p.ShelfStoreId).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Raf Deposu");
        }
    }
}
