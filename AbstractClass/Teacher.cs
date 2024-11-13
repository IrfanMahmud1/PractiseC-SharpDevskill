using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Teacher : User
    {
        public Teacher(string usesrname, string password) : base(usesrname, password)
        {
            id = "TE-" + new IdGenerator().Generate();
        }


        public override void CreateId()
        {
            throw new NotImplementedException();
        }
        
    }
}
