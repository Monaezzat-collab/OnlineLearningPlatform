using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string FullName { get; set; } = default!;
        public string EmailAddress { get; set; } = default!;
        public string? Bio { get; set; }
        public DateTime JoinDate { get; set; }

        //PublishRelationship (1:M) Navigation Property (collection Side)
        public ICollection<Course> PublishedCourse { get; set; } = new HashSet<Course>();
        
    }
}
