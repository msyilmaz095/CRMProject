using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class PaymentMethodValidator : AbstractValidator<PaymentMethod>
    {
        public PaymentMethodValidator()
        {
            RuleFor(p => p.PaymentMethodCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ödeme Şekli Kodu");
            RuleFor(p => p.PaymentMethodName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Ödeme Şekli Adı");
        }
    }

}
