using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ProjectMilestoneStatuValidator : AbstractValidator<ProjectMilestoneStatu>
    {
        public ProjectMilestoneStatuValidator()
        {
            RuleFor(p => p.ProjectMilestoneStatuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(60).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ad");
        }
    }

}
