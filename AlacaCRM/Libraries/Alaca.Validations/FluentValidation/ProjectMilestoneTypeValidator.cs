using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ProjectMilestoneTypeValidator : AbstractValidator<ProjectMilestoneType>
    {
        public ProjectMilestoneTypeValidator()
        {
            RuleFor(p => p.ProjectMilestoneTypeName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(60).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Proje Süreç Türü");
        }
    }

}
