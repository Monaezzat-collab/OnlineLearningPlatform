using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.Name)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            //SelfReferenceRelationship(1:M)
            builder.HasOne(c => c.ParentCategory)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.ParentCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            //(1:M) BelongsTo Relationship with many courses
            builder.HasMany(c=>c.IncludedCourses)
                   .WithOne(co=>co.BelongsTo)
                   .HasForeignKey(co=>co.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            //----------------- SEED DATA------------------
            //(id,name,description "Optional") & FK (ParentCategoryId)
            builder.HasData( 
                new Category { CategoryId = 1, Name = "Programming", Description = "All programming courses", ParentCategoryId = null },
                new Category { CategoryId = 2, Name = "Backend",     Description = "Server-side development", ParentCategoryId = 1 },
                new Category { CategoryId = 3, Name = "ASP.NET",     Description = "Web APIs and MVC",        ParentCategoryId = 2 },
                new Category { CategoryId = 4, Name = "Frontend",    ParentCategoryId = 1 },
                new Category { CategoryId = 5, Name = "Design",      Description = "UI and UX",               ParentCategoryId = null }
            );
        }
    }
}
