using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlovdivUniversity.Models.ViewModel
{
    public class InstructorIndexData
    {
        public IEnumerable<Models.Instructors> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}