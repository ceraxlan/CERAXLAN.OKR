using CERAXLAN.Core.Persistence.Repositories;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;
using CERAXLAN.OKR.ProductApi.Persistence.Context;

namespace CERAXLAN.OKR.ProductApi.Persistence.Repositories
{
    public class ProductRepository : EfRepositoryBase<Product, ProductContext>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }
    }
}
