using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "All programming courses", "Programming", null },
                    { 5, "UI and UX", "Design", null }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Bio", "EmailAddress", "FullName", "JoinDate" },
                values: new object[,]
                {
                    { 1, "Senior backend developer", "ahmed.hassan@example.com", "Ahmed Hassan", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "sara.ali@example.com", "Sara Ali", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Frontend and UI trainer", "khaled.samir@example.com", "Khaled Samir", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "EmailAddress", "FullName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona.ezzat@example.com", "Mona Ezzat" },
                    { 2, new DateTime(1999, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar.khaled@example.com", "Omar Khaled" },
                    { 3, new DateTime(2001, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "laila.nabil@example.com", "Laila Nabil" },
                    { 4, new DateTime(1998, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.adel@example.com", "Youssef Adel" },
                    { 5, new DateTime(2002, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "nour.hamdy@example.com", "Nour Hamdy" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Server-side development", "Backend", 1 },
                    { 4, null, "Frontend", 1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "Description", "InstructorId", "Level", "Price", "PublishedDate", "Title" },
                values: new object[] { 5, 5, "Coming soon", 3, 1, 299.50m, null, "UI Design Principles" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "ParentCategoryId" },
                values: new object[] { 3, "Web APIs and MVC", "ASP.NET", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 3, 2, null, 2, true, 2, 350.50m, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# for Backend" },
                    { 4, 4, "Start your frontend path", 3, true, 1, 199.00m, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTML and CSS Basics" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "Description", "InstructorId", "Level", "Price", "PublishedDate", "Title" },
                values: new object[] { 6, 2, "Draft course", 1, 3, 999.00m, null, "Microservices with .NET" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 3, "Build web apps step by step", 1, true, 1, 499.99m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET Core Fundamentals" },
                    { 2, 3, "Deep dive into EF Core", 1, true, 3, 799.00m, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced EF Core" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "FinalGrade", "ProgressPercentage", "Status" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 3 },
                    { 3, 4, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.25m, 100, 2 },
                    { 4, 3, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 70, 1 },
                    { 4, 5, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1 },
                    { 1, 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.50m, 100, 2 },
                    { 1, 2, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.00m, 100, 2 },
                    { 2, 1, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
