using AutoMapper;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;
using CERAXLAN.OKR.ProductApi.Persistence.Repositories;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdatedProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var mappedProduct = _mapper.Map<Product>(request);
            var updatedProduct = await _productRepository.UpdateAsync(mappedProduct);
            var updatedProductDto = _mapper.Map<UpdatedProductDto>(updatedProduct);
            return updatedProductDto;
        }
    }
}
