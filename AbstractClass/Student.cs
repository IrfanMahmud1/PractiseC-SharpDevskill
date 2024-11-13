using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Student : User
    {
        public Student(string usesrname, string password) : base(usesrname, password)
        {
            
        }
        public override void ChangePassword(string a, string b)
        {

        }


        public override void CreateId()
        {
            id = "ST-" + new IdGenerator().Generate();
        }
    }
}
