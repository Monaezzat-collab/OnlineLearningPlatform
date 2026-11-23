using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }


        //Self Referece Relationship(1:M)
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; } = default!;
        public ICollection<Category> SubCategories { get; set; } = new HashSet<Category>();

        //Navigation Property Collection Side (1:M)
        public ICollection<Course> IncludedCourses { get; set; }= new HashSet<Course>();
        

    }
}
