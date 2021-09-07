using Alaca.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Validations.FluentValidation
{
    public class CustomerValitador : AbstractValidator<Customer>
    {
        public CustomerValitador()
        {
            RuleFor(p => p.CustomerCode).
                NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").Length(5, 25).WithMessage("{PropertyName} Min. {MinLength} karakter Max. {MaxLength} karakter olabilir.!").WithName("Müşteri Kodu");
            RuleFor(p => p.CustomerName).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").Length(5, 255).WithMessage("{PropertyName} Min. {MinLength} karakter Max. {MaxLength} karakter olabilir.!").WithName("Müşteri Adı");
            RuleFor(p => p.CustomerTitle).MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kısa Ad");
            RuleFor(p => p.Phone1).MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Tel-1");
            RuleFor(p => p.Phone2).MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Tel-2");
            RuleFor(p => p.Fax).MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Fax");
            RuleFor(p => p.WebSite).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Web Site");
            RuleFor(p => p.Email).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").EmailAddress().WithName("Email");
            RuleFor(p => p.TaxAdministration).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Veri Dairesi");
            RuleFor(p => p.TaxNumber).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Vergi Numarası");
            RuleFor(p => p.IbanNo1).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Iban No-1");
            RuleFor(p => p.IbanNo2).MaximumLength(55).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Iban No-2");
            RuleFor(p => p.Explanation).MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
            RuleFor(p => p.CustomField1).MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-1");
            RuleFor(p => p.CustomField2).MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-2");
            RuleFor(p => p.CustomField3).MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Özel Kod-3");
        }
    }
}
