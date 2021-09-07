using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ExpenseCardValidator : AbstractValidator<ExpenseCard>
    {
        public ExpenseCardValidator()
        {
            RuleFor(p => p.ExpenseCardCode).
                 NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                 MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Masraf Kod");
            RuleFor(p => p.ExpenseCardName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Masraf Adı");
        }
    }
}
