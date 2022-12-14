using AutoMapper;
using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Commands.CreateProduct;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Dtos;
using CERAXLAN.OKR.ProductApi.Application.Features.Products.Models;
using CERAXLAN.OKR.ProductApi.Domain.Entities;

namespace CERAXLAN.OKR.ProductApi.Application.Features.Products.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreatedProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<IPaginate<Product>, ProductListModel>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();

            //CreateMap<Product, ProductGetByIdDto>().ReverseMap();

            //CreateMap<Product, DeleteProductCommand>().ReverseMap();
            //CreateMap<Product, DeletedProductDto>().ReverseMap();

            //CreateMap<Product, UpdateProductCommand>().ReverseMap();
            //CreateMap<Product, UpdatedProductDto>().ReverseMap();
        }
    }
}
