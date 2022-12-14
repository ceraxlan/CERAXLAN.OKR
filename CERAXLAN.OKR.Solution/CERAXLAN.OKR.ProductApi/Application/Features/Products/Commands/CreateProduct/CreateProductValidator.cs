using FluentValidation;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Product cannot be left blank.");
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0).WithMessage("Product Price must be greater than zero");
        }
    }
}
