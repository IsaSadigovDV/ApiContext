using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Service.Dtos.Products
{
	public class ProductPostDto
	{
        public string Name { get; set; }
        public string Price { get; set; }
        public IFormFile? File { get; set; }
        public int CategoryId { get; set; }
    }
}

