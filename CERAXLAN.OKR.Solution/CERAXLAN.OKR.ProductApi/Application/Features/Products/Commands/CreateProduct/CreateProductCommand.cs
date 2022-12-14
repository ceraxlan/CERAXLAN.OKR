using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<CreatedProductDto>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
