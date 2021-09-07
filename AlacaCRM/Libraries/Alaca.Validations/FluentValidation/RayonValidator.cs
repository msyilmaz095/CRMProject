using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class RayonValidator : AbstractValidator<Rayon>
    {
        public RayonValidator()
        {
            RuleFor(p => p.RayonCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Sektör Adı");
            RuleFor(p => p.RayonName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Reyon Adı");
        }
    }

}
