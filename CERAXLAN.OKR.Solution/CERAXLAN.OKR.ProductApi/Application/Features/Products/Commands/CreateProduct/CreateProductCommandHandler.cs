using AutoMapper;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Rules;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreatedProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ProductBusinessRules _productBusinessRules;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<CreatedProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            #region BusinessRules
            await _productBusinessRules.ProductNameCanNotBeDuplicatedWhenInserted(request.Name);
            #endregion

            #region Repository
            Product mappedProduct = _mapper.Map<Product>(request);
            Product createdProduct = await _productRepository.AddAsync(mappedProduct);
            CreatedProductDto createdProductDto = _mapper.Map<CreatedProductDto>(createdProduct);
            #endregion

            return createdProductDto;
        }
    }
}
