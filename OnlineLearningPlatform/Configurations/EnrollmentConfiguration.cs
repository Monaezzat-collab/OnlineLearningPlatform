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
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => new { e.CourseId, e.StudentId });

            builder.Property(e => e.EnrollmentDate)
                .IsRequired();

            builder.Property(e => e.FinalGrade)
                .HasPrecision(5, 2);

            builder.ToTable(t => t.HasCheckConstraint(
               "CK_Enrollment_Progress",
               $"[{ nameof(Enrollment.ProgressPercentage)}] >= 0 AND [{nameof(Enrollment.ProgressPercentage)}] <= 100"

               ));


            //(1 student:Many Enrollments)
            builder.HasOne(e=>e.StudentEnrollment)
                    .WithMany(s=>s.StudentEnrollments)
                    .HasForeignKey(e=>e.StudentId)
                    .OnDelete(DeleteBehavior.Cascade);


            //(1 course:Many Enrollments)
            builder.HasOne(e=>e.EnrollmentCourse)
                .WithMany(co=>co.CourseEnrollments)
                .HasForeignKey(e=>e.CourseId) 
                .OnDelete(DeleteBehavior.Cascade);

            //----------------- SEED DATA------------------
            //(EnrollmentDate,ProgressPercentage,status,finalGrade"optional") & CompositeKey (StudentId,CourseId)
            builder.HasData
                (
                new Enrollment { StudentId = 1, CourseId = 1, EnrollmentDate = new DateTime(2024, 2, 1), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 92.50m },
                new Enrollment { StudentId = 1, CourseId = 2, EnrollmentDate = new DateTime(2024, 3, 20), ProgressPercentage = 45, Status = EnrollmentStatus.Active, FinalGrade = null },
                new Enrollment { StudentId = 2, CourseId = 1, EnrollmentDate = new DateTime(2024, 2, 3), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 85.00m },
                new Enrollment { StudentId = 2, CourseId = 3, EnrollmentDate = new DateTime(2024, 5, 1), ProgressPercentage = 10, Status = EnrollmentStatus.Dropped, FinalGrade = null },
                new Enrollment { StudentId = 3, CourseId = 4, EnrollmentDate = new DateTime(2024, 5, 10), ProgressPercentage = 70, Status = EnrollmentStatus.Active, FinalGrade = null },
                new Enrollment { StudentId = 4, CourseId = 3, EnrollmentDate = new DateTime(2024, 5, 12), ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 78.25m },
                new Enrollment { StudentId = 5, CourseId = 4, EnrollmentDate = new DateTime(2024, 6, 1), ProgressPercentage = 0, Status = EnrollmentStatus.Active, FinalGrade = null }
                );
        }
    }
}
