using FluentValidation;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
        }
    }
}
