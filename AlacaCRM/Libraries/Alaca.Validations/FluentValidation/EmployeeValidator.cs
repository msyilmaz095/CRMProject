using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.Name).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Adı");
            RuleFor(p => p.Surname).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Soyadı");
            RuleFor(p => p.MobilePhone).
                MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Cep Telefon");
        }
    }

}
