using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdatedProductDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
