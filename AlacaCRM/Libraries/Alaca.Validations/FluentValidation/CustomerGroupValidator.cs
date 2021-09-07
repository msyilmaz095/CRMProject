using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class CustomerGroupValidator : AbstractValidator<CustomerGroup>
    {
        public CustomerGroupValidator()
        {
            RuleFor(p => p.CustomerGroupName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Müşteri Grup Adı");
        }
    }

}
