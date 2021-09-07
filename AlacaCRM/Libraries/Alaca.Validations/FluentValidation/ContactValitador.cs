using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ContactValitador : AbstractValidator<Contact>
    {
        public ContactValitador()
        {
            RuleFor(p => p.SureName).MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Soyadı");
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adı");
            RuleFor(p => p.Explanation).MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
            RuleFor(p => p.MobilePhoneNumber).MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adres");
            RuleFor(p => p.OfficePhoneNumber).MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adres");
            RuleFor(p => p.OfficePhoneNumberInternalCode).MaximumLength(5).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ofis Kod");
            RuleFor(p => p.Email).MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Email");
        }
    }
}
