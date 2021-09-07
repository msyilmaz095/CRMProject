using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class WorkTaskTypeValidator : AbstractValidator<WorkTaskType>
    {
        public WorkTaskTypeValidator()
        {
            RuleFor(p => p.WorkTaskTypeName).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İş Emri Tip Adı");
            RuleFor(p => p.Description).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(250).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İş Emri Tip Açıklaması");

        }
    }
}
