using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    internal class Enrollment
    {
        public DateTime EnrollmentDate { get; set; }
        public int ProgressPercentage { get; set; }
        public EnrollmentStatus Status { get; set; }
        public decimal? FinalGrade { get; set; }

        //Many Side With STUDENT&COURSE Entities, Navigation Property Reference Side
        public int StudentId { get; set; }
        public Student StudentEnrollment { get; set; } = default!;
        public int CourseId { get; set; }
        public Course EnrollmentCourse { get; set; } = default!;



    }
}
