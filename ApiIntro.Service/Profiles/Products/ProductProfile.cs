using ApiIntro.Core.Entities;
using ApiIntro.Service.Dtos.Categories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntro.Service.Profiles.Products
{
    public class ProductProfile:Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, ProductGetDto>();
            CreateMap<ProductPostDto, Product>();
        }
    }
}
