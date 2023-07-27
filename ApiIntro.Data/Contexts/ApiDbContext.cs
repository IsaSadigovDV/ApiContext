using System;
using ApiIntro.Core.Entities;
using ApiIntro.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ApiIntro.Data.Contexts
{
	public class ApiDbContext:DbContext
	{
		public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}

