using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ConfigurationValidator : AbstractValidator<Configuration>
    {
        public ConfigurationValidator()
        {
            RuleFor(p => p.ConfigurationCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kod");
            RuleFor(p => p.ConfigurationValue).
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Değer");
            RuleFor(p => p.ConfigurationDescription).
                MaximumLength(500).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }

}
