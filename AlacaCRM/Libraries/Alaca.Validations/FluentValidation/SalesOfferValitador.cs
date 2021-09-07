using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class SalesOfferValitador : AbstractValidator<SalesOffer>
    {
        public SalesOfferValitador()
        {
            RuleFor(p => p.SalesOfferNumber).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").Length(5, 25).WithMessage("{PropertyName} Min. {MinLength} karakter Max. {MaxLength} karakter olabilir.!").WithName("Teklif No");
            RuleFor(p => p.SalesOfferDate).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Teklif Tarihi");
            RuleFor(p => p.CustomerId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Müşteri");
            RuleFor(p => p.AssignedTo).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Temsilci");
            RuleFor(p => p.CurrencyId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Para Birimi");
            RuleFor(p => p.SalesOfferStatuId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Durum");
        }
    }
}
