using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class IdGenerator
    {
        public string Generate()
        {
            return new Random(DateTime.Now.Microsecond).Next(200, 999).ToString();
        }
    }
}
