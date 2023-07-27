using ApiIntro.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntro.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(20);
            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(x=>x.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow.AddHours(4));
        }
    }
}
