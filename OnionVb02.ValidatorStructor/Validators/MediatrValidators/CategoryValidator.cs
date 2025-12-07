using FluentValidation;
using OnionVb02.Application.DTOClasses;

namespace OnionVb02.ValidatorStructor.Validators.MediatrValidators

{
    public class CategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boş olamaz.");
        }
    }

}
