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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i=>i.InstructorId);

            builder.Property(i => i.FullName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(i => i.EmailAddress)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasIndex(i => i.EmailAddress)
                 .IsUnique(true);

            builder.Property(i=>i.Bio)
                   .IsRequired(false)
                   .HasMaxLength(500);

            builder.Property(i => i.JoinDate).IsRequired();

            //Relationship with course (1 Insturctor:M Courses)
            builder.HasMany(i=>i.PublishedCourse)
                   .WithOne(co=>co.Publish)
                   .HasForeignKey(co=>co.InstructorId)
                   .OnDelete(DeleteBehavior.Restrict);



            //------------SEED DATA-------------
            //(id,name,email,bio"optional",joinedDate)
            builder.HasData
                (
                new Instructor { InstructorId = 1, FullName = "Ahmed Hassan", EmailAddress = "ahmed.hassan@example.com", Bio = "Senior backend developer", JoinDate = new DateTime(2023, 1, 15) },
                new Instructor { InstructorId = 2, FullName = "Sara Ali", EmailAddress = "sara.ali@example.com", Bio = null, JoinDate = new DateTime(2023, 6, 1) },
                new Instructor { InstructorId = 3, FullName = "Khaled Samir", EmailAddress = "khaled.samir@example.com", Bio = "Frontend and UI trainer", JoinDate = new DateTime(2024, 2, 20) }
                );
        }
    }
}
