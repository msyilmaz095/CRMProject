using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CustomerLocationValitador : AbstractValidator<CustomerLocation>
    {
        public CustomerLocationValitador()
        {
            RuleFor(p => p.CustomerLocationName).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Lokasyon Adı");
            RuleFor(p => p.LocationTypeId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Lokasyon Tipi");
            RuleFor(p => p.CityId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("Şehir");
            RuleFor(p => p.DistrictId).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").WithName("İlçe");
            RuleFor(p => p.Address).NotEmpty().WithMessage("{PropertyName} Boş Geçilemez!").MaximumLength(300).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adres");
        }
    }
}
