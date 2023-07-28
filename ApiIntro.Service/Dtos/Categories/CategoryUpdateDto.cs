using System;
namespace ApiIntro.Service.Dtos.Categories
{
	public record ProductUpdateDto
	{
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}

