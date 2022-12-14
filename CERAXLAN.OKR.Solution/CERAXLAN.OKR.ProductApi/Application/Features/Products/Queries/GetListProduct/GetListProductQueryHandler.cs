using AutoMapper;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Models;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetListProduct
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, ProductListModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetListProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductListModel> Handle(GetListProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

            var mappedProductListModel = _mapper.Map<ProductListModel>(products);

            return mappedProductListModel;
        }
    }
}
