using CERAXLAN.Core.Persistence.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;

namespace CERAXLAN.OKR.ProductApi.Application.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
    }
}
