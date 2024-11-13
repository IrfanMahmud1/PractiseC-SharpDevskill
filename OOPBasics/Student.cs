using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Student : User
    {
        public Student(string usesrname, string password) : base(usesrname, password)
        {
            
        }

        public new void  CreateId()
        {
            id = "ST-" + new IdGenerator().Generate();
        }
    }
}
