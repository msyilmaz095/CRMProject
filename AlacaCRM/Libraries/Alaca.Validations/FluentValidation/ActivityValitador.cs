using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ActivityValitador : AbstractValidator<Activity>
    {
        public ActivityValitador()
        {
            RuleFor(p => p.Location).MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Lokasyon");
            RuleFor(p => p.StartDate).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Başlama Tarihi");
            RuleFor(p => p.ActivityTypeId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Aktivite Türü");
            RuleFor(p => p.FinishDate).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Bitiş Tarihi");
            RuleFor(p => p.Subject).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(150).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Konu");
            RuleFor(p => p.Explanation).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(2000).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }
}
