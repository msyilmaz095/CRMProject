using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ServiceCardValidator : AbstractValidator<ServiceCard>
    {
        public ServiceCardValidator()
        {
            RuleFor(p => p.ServiceCardCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Hizmet Kod");
            RuleFor(p => p.ServiceCardName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Hizmet Adı");
        }
    }
}
