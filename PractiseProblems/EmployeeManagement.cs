using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class EmployeeManagement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public double Increment(int percent)
        {
            return Salary * percent/100;
        }
    }
}
