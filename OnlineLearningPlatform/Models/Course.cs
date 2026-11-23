using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Level Level { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }


        //PublishRelationship(1:M), Many Side >> FK(Instructor)
        public int InstructorId { get; set; }
       //Navigaiton Property Reference Side
        public Instructor Publish { get; set; } = default!;


        //BelongsTo Relationship(1:M) >> FK(Category) Many
        public int CategoryId { get; set; }
        //Navigation Property (reference side)
        public Category BelongsTo { get; set; } = default!;


        //ONE Side With Enrollment Entity, Navigation Property Collection Side
        public ICollection<Enrollment> CourseEnrollments { get; set; } = new HashSet<Enrollment>();




    }
}
