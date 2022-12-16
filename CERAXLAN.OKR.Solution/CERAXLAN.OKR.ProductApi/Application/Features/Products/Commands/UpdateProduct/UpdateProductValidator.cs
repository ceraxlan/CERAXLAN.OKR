using FluentValidation;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Price).NotNull().GreaterThanOrEqualTo(0).LessThanOrEqualTo(100000);          
        }
    }
}
