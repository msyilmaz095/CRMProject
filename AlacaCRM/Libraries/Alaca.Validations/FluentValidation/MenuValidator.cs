using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.MenuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Menu Ad");
            RuleFor(p => p.Icon).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Icon");
            RuleFor(p => p.Url).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(250).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Url");
            RuleFor(p => p.Url).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }

}
