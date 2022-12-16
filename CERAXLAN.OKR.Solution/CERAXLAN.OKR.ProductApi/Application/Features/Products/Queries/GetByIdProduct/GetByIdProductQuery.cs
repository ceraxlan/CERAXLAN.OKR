using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetByIdProduct
{
    public class GetByIdProductQuery : IRequest<ProductGetByIdDto>
    {
        public int Id { get; set; }
    }
}
