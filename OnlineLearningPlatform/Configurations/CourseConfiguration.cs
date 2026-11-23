using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(co => co.CourseId);

            builder.Property(co => co.Title)
                   .IsRequired(true)
                   .HasMaxLength(200);

            builder.Property(co => co.Description)
                   .HasMaxLength(2000);

            builder.Property(co => co.Price)
                   .HasPrecision(10, 2);

            builder.Property(co => co.IsPublished)
                   .HasDefaultValue(false);

            builder.Property(co => co.PublishedDate)
                .IsRequired(false);


            #region RELATIONSHIP CONFIRMATION
            
            builder.HasOne(co => co.BelongsTo)
                    .WithMany(c => c.IncludedCourses)
                    .HasForeignKey(co=>co.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(co => co.Publish)
                   .WithMany(i => i.PublishedCourse)
                   .HasForeignKey(co => co.InstructorId)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion

            //-----------------DATA SEED-------------------
            //(courseId,title,description,price,level,ispublished,publishedDate) & FK(InstructorId, CategoryId)
            builder.HasData(

                new Course { CourseId = 1, Title = "ASP.NET Core Fundamentals", Description = "Build web apps step by step", Price = 499.99m, Level = Level.Beginner, IsPublished = true, PublishedDate = new DateTime(2024, 1, 10), InstructorId = 1, CategoryId = 3 },
                new Course { CourseId = 2, Title = "Advanced EF Core", Description = "Deep dive into EF Core", Price = 799.00m, Level = Level.Advanced, IsPublished = true, PublishedDate = new DateTime(2024, 3, 5), InstructorId = 1, CategoryId = 3 },
                new Course { CourseId = 3, Title = "C# for Backend", Description = null, Price = 350.50m, Level = Level.Intermediate, IsPublished = true, PublishedDate = new DateTime(2024, 4, 18), InstructorId = 2, CategoryId = 2 },
                new Course { CourseId = 4, Title = "HTML and CSS Basics", Description = "Start your frontend path", Price = 199.00m, Level = Level.Beginner, IsPublished = true, PublishedDate = new DateTime(2024, 5, 2), InstructorId = 3, CategoryId = 4 },
                new Course { CourseId = 5, Title = "UI Design Principles", Description = "Coming soon", Price = 299.50m, Level = Level.Beginner, IsPublished = false, PublishedDate = null, InstructorId = 3, CategoryId = 5 },
                new Course { CourseId = 6, Title = "Microservices with .NET", Description = "Draft course", Price = 999.00m, Level = Level.Advanced, IsPublished = false, PublishedDate = null, InstructorId = 1, CategoryId = 2 }
                );

        }
    }
}
