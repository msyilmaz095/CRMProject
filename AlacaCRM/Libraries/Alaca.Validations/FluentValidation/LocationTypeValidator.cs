using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class LocationTypeValidator : AbstractValidator<LocationType>
    {
        public LocationTypeValidator()
        {
            RuleFor(p => p.LocationTypeName).
                NotEmpty().WithMessage("{PropertyName} Boş geçilemez.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.").WithName("Lokasyon Tür Adı");
        }
    }

}
