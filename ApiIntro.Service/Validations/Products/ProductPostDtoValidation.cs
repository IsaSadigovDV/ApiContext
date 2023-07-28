using ApiIntro.Service.Dtos.Categories;
using ApiIntro.Service.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiIntro.Service.Extentions;
using System.Threading.Tasks;
namespace ApiIntro.Service.Validations.Products
{
    public class ProductPostDtoValidation:AbstractValidator<ProductPostDto>
    {
        public ProductPostDtoValidation() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30);
            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.File.IsImage())
                {
                    context.AddFailure("File", "This is not image file");
                }
            });
        }
    }
}
