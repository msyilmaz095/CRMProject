using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(p => p.CompanyName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Firma Adı");
            RuleFor(p => p.ContactName).
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Yetkil Kişi");
            RuleFor(p => p.Adress).
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adres");
            RuleFor(p => p.Description).
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
            RuleFor(p => p.ConnectionString).
                MaximumLength(855).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Connection");
            RuleFor(p => p.Phone).
                MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Telefon");
        }
    }

}
