using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.DbContexts;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Start Connection With Database >> Change Tracker
            using var Context = new OnlineLearningDbContext();

            #region ADD Instructor
            //var newInstructor = new Instructor //Detached
            //{
            //    FullName = "Mohamed Fathy",
            //    EmailAddress = $"mohamed{Guid.NewGuid().ToString("N")[..5]}@example.com",
            //    Bio = "Software architecture trainer",
            //    JoinDate = DateTime.Now
            //};
            //Context.Instructors.Add(newInstructor); //Added
            //Context.SaveChanges(); //Unchanged

            ////var state = Context.Entry(newInstructor).State;
            ////Console.WriteLine(state);

            //Console.WriteLine($"Instructor Added. Id={newInstructor.InstructorId}");
            #endregion

            #region ADD Course
            //var newCourse = new Course
            //{
            //    Title = "ASP.NET Core Fundamentals",
            //    Description = "Learn how to build modern web applications using ASP.NET Core and Entity Framework Core.",
            //    Price = 499.99m,
            //    Level = Level.Beginner,
            //    IsPublished = true,
            //    PublishedDate = DateTime.Now,
            //    CategoryId = 5,
            //    InstructorId = 2,

            //};

            //Context.Courses.Add(newCourse);
            //Context.SaveChanges();
            //Console.WriteLine($"Course added. Generated Id = {newCourse.CourseId}");

            #endregion

            #region ADD Students
            //string tag = Guid.NewGuid().ToString("N")[..5];
            //var newStudents = new List<Student>
            //    {
            //        new Student { FullName = "Ali Mahmoud", EmailAddress = $"ali{tag}@example.com",  DateOfBirth = new DateTime(2001, 1, 10) },
            //        new Student { FullName = "Hana Tarek",  EmailAddress = $"hana{tag}@example.com", DateOfBirth = new DateTime(2002, 4, 22) },
            //        new Student { FullName = "Karim Wael",  EmailAddress = $"karim{tag}@example.com", DateOfBirth = new DateTime(2000, 9, 5) }
            //    };
            //Context.Students.AddRange(newStudents);
            //Context.SaveChanges();

            //var generatedIds = newStudents.Select(s => s.StudentId).ToList();
            //Console.WriteLine("Students Added. generatedIds: " + string.Join(", ", generatedIds));
            #endregion

            #region ADD EnrollStudent

            //int enrollStudentId = 1;
            //int enrollCourseId = 4;

            //var enrollStudent = await Context.Students.FindAsync(enrollStudentId);
            //var enrollCourse = await Context.Courses.FindAsync(enrollCourseId);

            //if (enrollStudent == null)
            //{
            //    Console.WriteLine($"Enrollment Refused: Student {enrollStudentId} Does Not Exist.");
            //}
            //else if (enrollCourse == null)
            //{
            //    Console.WriteLine($"Enrollment Refused: Couse {enrollCourseId} Does Not Exist.");
            //}
            //else if (Context.Enrollments.Any(e => e.StudentId == enrollStudentId && e.CourseId == enrollCourseId))
            //{
            //    Console.WriteLine($"Enrollment refused: {enrollStudent.FullName} is already enrolled in '{enrollCourse.Title}'.");
            //}
            //else
            //{
            //    Context.Enrollments.Add(new Enrollment
            //    {
            //        StudentId = enrollStudentId,
            //        CourseId = enrollCourseId,
            //        EnrollmentDate = DateTime.Now,
            //        ProgressPercentage = 0,
            //        Status = EnrollmentStatus.Active
            //    });
            //    Context.SaveChanges();
            //    Console.WriteLine($"{enrollStudent.FullName} enrolled in {enrollCourse.Title} successfully");
            //};


            #endregion

            #region READ FindACourse

            //var courseById = await Context.Courses.FindAsync(1);
            //if (courseById == null)
            //{
            //    Console.WriteLine($"{courseById?.CourseId}Is Not Found");
            //}
            //else if (courseById != null)
            //{
            //    Console.WriteLine($"Course Id: {courseById.CourseId}");
            //}

            //var courseByTitle = await Context.Courses.FirstOrDefaultAsync(co => co.Title == "Advanced EF Core");
            //if (courseByTitle == null)
            //{
            //    Console.WriteLine("This Course Title Is Not Found");
            //}
            //else if (courseByTitle != null)
            //{
            //    Console.WriteLine($"By title: {courseByTitle.Title} (Id {courseByTitle.CourseId})");
            //}

            #endregion

            #region READ FilterCourses
            //decimal minPrice = 200m;
            //decimal maxPrice = 700m;
            //var filteredCourses = Context.Courses
            //                    .Where(co => co.Price >= minPrice && co.Price <= maxPrice)
            //                    .OrderByDescending(co => co.Price)
            //                    .Select(co => new { co.Title, co.Level, co.Price })
            //                    .ToList();

            //foreach (var co in filteredCourses)
            //{
            //    Console.WriteLine($"Title: {co.Title}, Level: {co.Level}, Price: {co.Price}");
            //}

            #endregion

            #region READ Sub-Categories

            //int parentCategoryId = 1;

            //var subCategories = Context.Categories
            //                    .Where(c => c.ParentCategoryId == parentCategoryId)
            //                    .ToList();
            //Console.WriteLine($"Direct SubCategories Of {parentCategoryId}: ");
            //foreach (var c in subCategories)
            //{
            //    Console.WriteLine($"{c.Name}");
            //}


            //var topLevelCategories = Context.Categories
            //    .Where(c => c.ParentCategory == null)
            //    .ToList();
            //Console.WriteLine("Top Level Categories: ");
            //foreach (var top in topLevelCategories)
            //{
            //    Console.WriteLine($"{top.Name}");
            //}
            #endregion

            #region READ CourseRoster
            //int rosterCourseId = 1;

            //var enrollStudentIds = Context.Enrollments
            //    .Where(e => e.CourseId == rosterCourseId)
            //    .Select(e => e.StudentId)
            //    .ToList();

            //var rosterNames = Context.Students
            //    .Where(s => enrollStudentIds.Contains(s.StudentId))
            //    .Select(s => s.FullName)
            //    .ToList();

            //Console.WriteLine($"Roster Course Id: {rosterCourseId}");
            //foreach (var name in rosterNames)
            //{
            //    Console.WriteLine($"RosterName: {name}");
            //}

            #endregion

            #region UPDATE ChangePrice

            //var courseLoadingId = 1;
            //var courseLoading = await Context.Courses.FindAsync(courseLoadingId);
            ////connected senario >> TRACKED (unchanged, modified, unchanged)
            //if (courseLoading == null)
            //{
            //    Console.WriteLine("Course Not Found");
            //}
            //else if (courseLoading != null)
            //{
            //    decimal oldPrice = courseLoading.Price;
            //    courseLoading.Price = 900.99m;
            //    Context.SaveChanges();
            //    Console.WriteLine($"Price Of {courseLoading.Title}, {oldPrice} Updated To {courseLoading.Price}");
            //}

            #endregion

            #region UPDATE Progress
            //int progressCourseId = 4;
            //int progressStudentId = 3;
            //var newProgress = 100;

            //if (newProgress < 0 || newProgress > 100)
            //{
            //    Console.WriteLine($"Rejected: Progress {newProgress} must be between 0 and 100.");
            //}
            //else
            //{
            //    var updatedProgress = Context.Enrollments.Find(progressCourseId, progressStudentId);
            //    if (updatedProgress == null)
            //    {
            //        Console.WriteLine("Enrollment Is Not Found.");
            //    }
            //    else
            //    {
            //        updatedProgress.ProgressPercentage = newProgress;
            //        if (newProgress == 100)
            //        {
            //            updatedProgress.Status = EnrollmentStatus.Completed;
            //        }
            //        Context.SaveChanges();
            //        Console.WriteLine($"Current Progress = {updatedProgress.ProgressPercentage}, Status= {updatedProgress.Status}");
            //    }
            //}
            #endregion

            #region UPDATE Publish Course
            //int publishedCourseId = 3;
            //var publishedCourse = Context.Courses.Find(publishedCourseId);

            //if (publishedCourse == null)
            //{
            //    Console.WriteLine("Course is not found");
            //}
            //else
            //{
            //    publishedCourse.IsPublished = true;
            //    publishedCourse.PublishedDate = DateTime.Now;
            //    Context.SaveChanges();
            //    Console.WriteLine($"{publishedCourse.Title}, Published On {publishedCourse.PublishedDate:yyyy-MM-dd}");
            //}
            #endregion

            #region DELETE Unenroll
            //var unenrollment = Context.Enrollments.Find(1, 1); // course,student
            //if (unenrollment == null)
            //{
            //    Console.WriteLine("Enrollments Is Not found.");
            //}
            //else
            //{
            //    Context.Enrollments.Remove(unenrollment);
            //    Context.SaveChanges();
            //    Console.WriteLine("Unenrolled Successfully.");
            //}
            #endregion

            #region DELETE Category
            //var unsafeCategory = await Context.Categories.FindAsync(1);

            //if (unsafeCategory != null)
            //{
            //    try
            //    {
            //        Context.Categories.Remove(unsafeCategory);
            //        Context.SaveChanges();

            //    }
            //    catch (DbUpdateException ex)
            //    {
            //        Console.WriteLine("DbUpdateException: " + (ex.InnerException?.Message ?? ex.Message));
            //        Context.ChangeTracker.Clear();
            //    }
            //}

            //var safeCategory = await Context.Categories.FindAsync(3);
            //if (safeCategory == null)
            //{
            //    Console.WriteLine("Category not found.");
            //}
            //else if (await Context.Categories.AnyAsync(c => c.ParentCategoryId == safeCategory.CategoryId))
            //{
            //    Console.WriteLine($"Can Not delete {safeCategory.Name}: it still has sub-categories.");
            //}
            //else if (await Context.Categories.AnyAsync(c => c.CategoryId == safeCategory.CategoryId))
            //{
            //    Console.WriteLine($"Can Not delete {safeCategory.Name}: it still has courses.");
            //}
            //else
            //{
            //    Context.Categories.Remove(safeCategory);
            //    Context.SaveChanges();
            //    Console.WriteLine($"Category '{safeCategory.Name}' deleted.");
            //}
            #endregion

            #region DELETE Course with enrollments
            //int deleteCourseId = 3;
            //var courseToDelete = Context.Courses.Find(deleteCourseId);
            //if (courseToDelete == null)
            //    Console.WriteLine("Course not found.");
            //else
            //{
            //    int before = Context.Enrollments.Count(e => e.CourseId == deleteCourseId);
            //    Console.WriteLine($"Enrollments before delete: {before}");


            //    Context.Courses.Remove(courseToDelete);
            //    Context.SaveChanges();

            //    int after = Context.Enrollments.Count(e => e.CourseId == deleteCourseId);
            //    Console.WriteLine($"Enrollments after delete: {after}");
            //}
            #endregion

        }
    }
}
