using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class BarcodeTypeValidator : AbstractValidator<BarcodeType>
    {
        public BarcodeTypeValidator()
        {
            RuleFor(p => p.BarcodeTypeCode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(15).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Barkod Tür Kodu");
            RuleFor(p => p.BarcodeTypeName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(80).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Barkod Tür Adı");
        }
    }

}
