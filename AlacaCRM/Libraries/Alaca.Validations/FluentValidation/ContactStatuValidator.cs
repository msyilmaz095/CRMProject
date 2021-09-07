using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ContactStatuValidator : AbstractValidator<ContactStatu>
    {
        public ContactStatuValidator()
        {
            RuleFor(p => p.ContactStatuName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İletişim Durum Adı");
        }
    }

}
