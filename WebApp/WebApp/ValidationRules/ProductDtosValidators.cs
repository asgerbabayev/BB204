using FluentValidation;
using JwtExample.DTO_s.ProductDto_s;

namespace JwtExample.ValidationRules;

public class ProductPostDtoValidator : AbstractValidator<ProductPostDto>
{
    public ProductPostDtoValidator()
    {
        RuleFor(x => x.Name).NotNull()
            .NotEmpty()
            .WithMessage("Mehsul adi bosh kecilemez")
            .MaximumLength(200);
        RuleFor(x => x.Price).NotEmpty().NotNull();
    }
}