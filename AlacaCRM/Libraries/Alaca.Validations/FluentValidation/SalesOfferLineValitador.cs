using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class SalesOfferLineValitador : AbstractValidator<SalesOfferLine>
    {
        public SalesOfferLineValitador()
        {
            RuleFor(p => p.StockId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Ürün");
            RuleFor(p => p.Price).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Fiyat");
            RuleFor(p => p.Amount).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Miktar");
        }
    }
}
