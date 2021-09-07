using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserCode).
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kullanıcı Kod");
            RuleFor(p => p.UserName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kullanıcı Adı");
            RuleFor(p => p.Email).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(200).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Email");
            RuleFor(p => p.Password).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Parola");
            RuleFor(p => p.MobilePhone).
                MaximumLength(20).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Kullanıcı Tel");
            RuleFor(p => p.UserRoleId).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Kullanıcı Rolü");
        }
    }

}
