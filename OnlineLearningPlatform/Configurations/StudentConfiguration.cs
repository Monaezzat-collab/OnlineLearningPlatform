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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);

            builder.Property(s=>s.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.EmailAddress)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.HasIndex(s => s.EmailAddress)
                    .IsUnique(true);

            builder.Property(s => s.DateOfBirth)
                   .HasColumnType("date");


            //--------------SEED DATA-------------------
            //(id,name,email,DOB)
            builder.HasData
                (
                new Student { StudentId = 1, FullName = "Mona Ezzat", EmailAddress = "mona.ezzat@example.com", DateOfBirth = new DateTime(2000, 5, 20) },
                new Student { StudentId = 2, FullName = "Omar Khaled", EmailAddress = "omar.khaled@example.com", DateOfBirth = new DateTime(1999, 11, 2) },
                new Student { StudentId = 3, FullName = "Laila Nabil", EmailAddress = "laila.nabil@example.com", DateOfBirth = new DateTime(2001, 3, 8) },
                new Student { StudentId = 4, FullName = "Youssef Adel", EmailAddress = "youssef.adel@example.com", DateOfBirth = new DateTime(1998, 8, 14) },
                new Student { StudentId = 5, FullName = "Nour Hamdy", EmailAddress = "nour.hamdy@example.com", DateOfBirth = new DateTime(2002, 12, 25) }
                );


        }
    }
}
