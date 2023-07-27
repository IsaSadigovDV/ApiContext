using System;
using ApiIntro.Data.Contexts;
using ApiIntro.Core.Repositories.Interfaces;
using ApiIntro.Core.Entities;

namespace ApiIntro.Data.Repositories.Implementations
{
	public class CategoryRepository:Repository<Category>,ICategoryRepository 
	{
        private readonly ApiDbContext _context;

        public CategoryRepository(ApiDbContext context):base(context)
        {
          
        }
    }
}

