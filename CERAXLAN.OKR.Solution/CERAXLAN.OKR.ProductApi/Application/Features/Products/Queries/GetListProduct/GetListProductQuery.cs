using CERAXLAN.Core.Application.Requests;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Models;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetListProduct
{
    public class GetListProductQuery : IRequest<ProductListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
