using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Models
{
    public class ProductListModel : BasePageableModel
    {
        public IList<ProductListDto> Items { get; set; }
    }
}
