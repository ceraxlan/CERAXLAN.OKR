using AutoMapper;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Domain.Entities;
using MediatR;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeletedProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<DeletedProductDto> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var mappedProduct = _mapper.Map<Product>(request);
            var deletedProduct = await _productRepository.DeleteAsync(mappedProduct);
            var deletedProductDto = _mapper.Map<DeletedProductDto>(deletedProduct);
            return deletedProductDto;
        }
    }
}
