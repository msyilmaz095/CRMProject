using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ZoneValidator : AbstractValidator<Zone>
    {
        public ZoneValidator()
        {
            RuleFor(p => p.ZoneName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Bölge Adı");
        }
    }

}
