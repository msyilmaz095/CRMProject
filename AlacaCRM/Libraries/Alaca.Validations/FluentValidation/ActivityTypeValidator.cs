using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ActivityTypeValidator : AbstractValidator<ActivityType>
    {
        public ActivityTypeValidator()
        {
            RuleFor(p => p.ActivityTypeName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Aktivite Türü");
            RuleFor(p => p.IsContactExist).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("İletişim");
            RuleFor(p => p.IsCustomerExist).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Müşteri");
            RuleFor(p => p.IsEmployeeExist).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Personel");
            RuleFor(p => p.IsLocationExist).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Lokasyon");
            RuleFor(p => p.IsProjectExist).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Proje");
        }
    }

}
