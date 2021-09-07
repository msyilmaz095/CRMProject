using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ContactTypeValidator : AbstractValidator<ContactType>
    {
        public ContactTypeValidator()
        {
            RuleFor(p => p.ContactTypeName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İletişim Tür Adı");
        }
    }

}
