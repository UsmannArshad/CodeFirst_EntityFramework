using System;
using System.Collections.Generic;

namespace CodeFirst_EntityFramework
{
    public partial class Student
    {
        public Student()
        {
            AssignedCourses = new HashSet<AssignedCourse>();
        }

        public int Id { get; set; }
        public string StudentName { get; set; } = null!;
        public int StudentRollno { get; set; }
        public int marks { get; set; }
        public string FatherName { get; set; }
        public virtual ICollection<AssignedCourse> AssignedCourses { get; set; }
    }
}
