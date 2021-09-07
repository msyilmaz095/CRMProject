using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class WorkTaskValidator : AbstractValidator<WorkTask>
    {
        public WorkTaskValidator()
        {
            RuleFor(p => p.WorkTaskType).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("İş Emri Tipi");
            RuleFor(p => p.FinishDate).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Bitiş Tarihi");
            RuleFor(p => p.WorkTaskHeader).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Başlık");
            RuleFor(p => p.StartDate).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Başlangıç Tarihi");
            RuleFor(p => p.PersonToDo).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Yapacak Personel");

        }
    }
}
