using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeletedProductDto>
    {
        public int Id { get; set; }
    }
}
