using Alaca.Entities.Concrete;
using FluentValidation;

namespace Alaca.Validations.FluentValidation
{
    public class ProjectDocumentValidator : AbstractValidator<ProjectDocument>
    {
        public ProjectDocumentValidator()
        {
            RuleFor(p => p.ProjectDocumentName).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(255).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Döküman Adı");
            RuleFor(p => p.DocumentType).
                NotEmpty().WithMessage("{PropertyName} Boş Olamaz.").
                MaximumLength(50).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Döküman Türü");
            RuleFor(p => p.Description).
                MaximumLength(1000).WithMessage("{PropertyName} Max. {MaxLength} karakter olabilir.!").WithName("Açıklama");
        }
    }

}
