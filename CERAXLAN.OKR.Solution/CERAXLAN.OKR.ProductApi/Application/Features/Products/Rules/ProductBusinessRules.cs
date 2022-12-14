using CERAXLAN.Core.CrossCuttingConcerns.Exceptions;
using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Rules
{
    public class ProductBusinessRules
    {
        private readonly IProductRepository _productRepository;

        public ProductBusinessRules(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task ProductNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Product> result = await _productRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Product name exists.");
        }
    }
}
