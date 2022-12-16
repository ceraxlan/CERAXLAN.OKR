using AutoMapper;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Rules;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Queries.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, ProductGetByIdDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ProductBusinessRules _productBusinessRules;

        public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<ProductGetByIdDto> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(x => x.Id == request.Id);

            _productBusinessRules.ProductShouldExistWhenRequested(product);

            var productGetByIdDto = _mapper.Map<ProductGetByIdDto>(product);
            return productGetByIdDto;
        }
    }
}
