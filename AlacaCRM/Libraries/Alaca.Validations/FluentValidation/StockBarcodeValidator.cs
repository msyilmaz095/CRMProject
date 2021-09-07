using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class StockBarcodeValidator : AbstractValidator<StockBarcode>
    {
        public StockBarcodeValidator()
        {
            RuleFor(p => p.StockBarcodeName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Barkod Adı");
            RuleFor(p => p.Barcode).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Barkod");
            RuleFor(p => p.PartyCode).
                MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Parti Kodu");
            RuleFor(p => p.LotNumber).
                MaximumLength(30).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Lot No");
        }
    }

}
