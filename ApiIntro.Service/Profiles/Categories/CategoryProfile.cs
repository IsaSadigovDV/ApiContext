using System;
using ApiIntro.Service.Dtos.Categories;
using ApiIntro.Core.Entities;
using AutoMapper;

namespace ApiIntro.Service.Profiles.Categories
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			CreateMap<ProductPostDto, Category>();
			CreateMap<ProductUpdateDto, Category>();
			CreateMap<Category, ProductGetDto>();
        }
	}
}

