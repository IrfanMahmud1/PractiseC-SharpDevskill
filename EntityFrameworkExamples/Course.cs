using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }

        public List<Topic>? Topics { get; set; }

        public List<CourseEnrollment> CourseStudents { get; set; }
    }
}
