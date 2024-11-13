using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Teacher : User
    {
        public Teacher(string usesrname, string password) : base(usesrname, password)
        {
        }

        public void CreateId()
        {
            id = "TE-" + new IdGenerator().Generate();
        }
    }
}
