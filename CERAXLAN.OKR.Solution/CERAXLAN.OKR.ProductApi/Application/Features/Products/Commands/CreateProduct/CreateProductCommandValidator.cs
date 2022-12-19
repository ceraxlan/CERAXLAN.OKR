using FluentValidation;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Product cannot be left blank.");
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0).WithMessage("Product Price must be greater than zero");
        }
    }
}
