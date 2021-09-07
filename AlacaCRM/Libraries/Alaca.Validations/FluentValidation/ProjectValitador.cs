using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ProjectValitador : AbstractValidator<Project>
    {
        public ProjectValitador()
        {
            RuleFor(p => p.ProjectNumber).
                NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").
                MaximumLength(25).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Proje No");
            RuleFor(p => p.ProjectDate).
                NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Proje Tarihi");
            RuleFor(p => p.CustomerId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Müşteri");
            RuleFor(p => p.ProjectTitle).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Proje Başlık");
            RuleFor(p => p.ProjectDescription).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(250).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Proje Açıklama");
        }
    }
}
