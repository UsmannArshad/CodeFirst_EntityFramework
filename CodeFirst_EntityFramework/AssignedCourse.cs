using System;
using System.Collections.Generic;

namespace CodeFirst_EntityFramework
{
    public partial class AssignedCourse
    {
        public int Id { get; set; }
        public int AssignedCourseId { get; set; }
        public int StudentRollnumber { get; set; }

        public virtual Course AssignedCourseNavigation { get; set; } = null!;
        public virtual Student StudentRollnumberNavigation { get; set; } = null!;
    }
}
