using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class SubContratorTeamValidator : AbstractValidator<SubContratorTeam>
    {
        public SubContratorTeamValidator()
        {
            RuleFor(p => p.CityId).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").WithName("Şehir");
            RuleFor(p => p.SubcontratorTeamName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(100).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Takım Adı");
            RuleFor(p => p.SubcontratorTeamName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(500).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }

}
