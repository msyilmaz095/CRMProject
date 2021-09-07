using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(p => p.Name).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adı");
            RuleFor(p => p.SureName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Soyadı");
            RuleFor(p => p.MobilePhoneNumber).
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Çep Telefonu");
            RuleFor(p => p.OfficePhoneNumber).
                MaximumLength(500).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("İş Telefonu");
            RuleFor(p => p.OfficePhoneNumberInternalCode).
                MaximumLength(500).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kısa Kod");
            RuleFor(p => p.Explanation).
                MaximumLength(500).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }

}
