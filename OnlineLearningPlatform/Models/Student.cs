using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; } = default!;
        public string EmailAddress { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }

        //(M:M) EnrollmentRelationship
        //ONE Side With Enrollment Entity, Navigation Property Collection Side
        public ICollection<Enrollment> StudentEnrollments { get; set; } = new HashSet<Enrollment>();


    }
}
