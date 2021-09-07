using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CustomerRelationValidator : AbstractValidator<CustomerRelation>
    {
        public CustomerRelationValidator()
        {
            RuleFor(p => p.CustomerRelationName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İlişki Tür Adı");
        }
    }

}
