using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class SectorValidator : AbstractValidator<Sector>
    {
        public SectorValidator()
        {
            RuleFor(p => p.SectorName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Sektör Adı");
        }
    }

}
