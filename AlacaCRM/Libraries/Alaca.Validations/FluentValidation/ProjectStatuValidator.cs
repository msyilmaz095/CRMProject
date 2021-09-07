using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ProjectStatuValidator : AbstractValidator<ProjectStatu>
    {
        public ProjectStatuValidator()
        {
            RuleFor(p => p.ProjectStatuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Proje Durum Adı");
        }
    }

}
