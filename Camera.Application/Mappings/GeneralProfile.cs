using AutoMapper;
using Camera.Application.Features.Products.Commands.CreateProduct;
using Camera.Application.Features.Products.Queries.GetAllProducts;
using Camera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camera.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
