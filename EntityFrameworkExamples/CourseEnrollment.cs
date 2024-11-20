﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class CourseEnrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}
