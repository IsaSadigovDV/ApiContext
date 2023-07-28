using System;
namespace ApiIntro.Service.Dtos.Categories
{ 
    public record ProductGetDto
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
    }
}

