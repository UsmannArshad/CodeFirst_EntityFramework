using System;
using System.Collections.Generic;

namespace CodeFirst_EntityFramework
{
    public partial class Course
    {
        public Course()
        {
            AssignedCourses = new HashSet<AssignedCourse>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int CreditHours { get; set; }

        public virtual ICollection<AssignedCourse> AssignedCourses { get; set; }
    }
}
