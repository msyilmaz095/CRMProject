using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CustomerStatuValidator : AbstractValidator<CustomerStatu>
    {
        public CustomerStatuValidator()
        {
            RuleFor(p => p.CustomerStatusName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adı");
        }
    }

}
